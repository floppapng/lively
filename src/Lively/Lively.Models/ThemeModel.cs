﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lively.Models
{
    public class ThemeModel
    {
        public ThemeModel(string file, string preview, ThemeType type, string name, string description, string contact, string license)
        {
            Name = name;
            Description = description;
            Contact = contact;
            File = file;
            Preview = preview;
            Type = type;
            License = license;
        }

        public ThemeModel(ThemeModel model) 
        {
            Name = model.Name;
            Description = model.Description;
            Contact = model.Contact;
            Preview = model.Preview;
            Type = model.Type;
            File = model.File;
        }

        public ThemeModel() { }

        public string AppVersion { get; set; } = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string License { get; set; }
        public string File { get; set; }
        public string Preview { get; set; }
        public ThemeType Type { get; set; }

        [JsonIgnore]
        public bool IsEditable { get; set; }
    }

    public enum ThemeType
    {
        picture,
        shader
    }
}
