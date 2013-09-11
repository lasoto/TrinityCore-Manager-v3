using System;
using System.Text;
using TrinityCore_Manager.Extensions;

namespace TrinityCore_Manager.Commands
{
    public static class CommandsHelper
    {

        public static string BuildCommand(this TCCommand command, params string[] parameters)
        {

            var attrib = command.GetAttribute<TCCommandAttribute>();

            if (attrib.ParamsNum > parameters.Length)
                throw new ArgumentOutOfRangeException("parameters");

            var sb = new StringBuilder(attrib.CommandName);

            if (parameters.Length > 0)
            {

                if (!attrib.CommandName.EndsWith(" "))
                    sb.Append(' ');

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (i == parameters.Length - 1)
                        sb.Append(parameters[i]);
                    else
                        sb.Append(parameters[i] + " ");
                }

            }

            return sb.ToString();

        }

    }
}
