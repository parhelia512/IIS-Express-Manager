﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace IISExpressManager
{
    public interface IFileIO
    {
        event EventHandler FileChanged;

        IEnumerable<XElement> GetSitesSection();
        bool Exists(string path);
        void Save(XElement site, int id);
        void Delete(XElement site, int id);
    }
}
