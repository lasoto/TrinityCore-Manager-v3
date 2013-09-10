using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Caching;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TrinityCore_Manager.Misc
{
    public class WoWItem
    {

        private readonly ObjectCache _imageCache = MemoryCache.Default;

        private const string ItemBase = "http://us.battle.net/api/wow/item/";
        private const string IconBase56 = "http://us.media.blizzard.com/wow/icons/56/";

        public static readonly string ImageFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "imgs");

        public static Image UnknownImage = Properties.Resources.questionmark;

        public int Quantity { get; set; }

        public JObject Data { get; private set; }


        public int ItemId
        {
            get
            {
                return (int)Data["id"];
            }
        }

        private WoWItem(string data)
        {
            Data = JObject.Parse(data);
        }

        public async static Task<WoWItem> GetItem(int itemId)
        {

            using (var client = new WebClient())
            {

                string data = await client.DownloadStringTaskAsync(new Uri(ItemBase + itemId.ToString()));

                return new WoWItem(data);

            }

        }

        public async Task<Image> GetIconTaskAsync()
        {

            try
            {

                if (_imageCache.Contains(ItemId.ToString()))
                    return (Image)_imageCache.Get(ItemId.ToString());

                if (Data == null)
                    throw new NullReferenceException("Data null");

                string iconName = (string)Data["icon"];

                if (String.IsNullOrEmpty(iconName))
                    throw new Exception("Icon not available!");

                using (var client = new WebClient())
                {

                    string fileName = IconBase56 + iconName + ".jpg";

                    byte[] data = await client.DownloadDataTaskAsync(fileName);

                    using (var ms = new MemoryStream(data))
                    {

                        var image = Image.FromStream(ms);

                        _imageCache.Add(ItemId.ToString(), image, DateTime.Now.AddHours(1));

                        return image;

                    }

                }

            }
            catch (Exception)
            {
                return Properties.Resources.questionmark;
                //return Image.FromFile(Path.Combine(ImageFolder, "questionmark.png"));
            }

        }

    }
}
