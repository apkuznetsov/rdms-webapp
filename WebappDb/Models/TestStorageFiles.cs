﻿using System;
using System.Collections.Generic;

namespace Db
{
    public partial class TestStorageFiles
    {
        public int TestStorageFileId { get; set; }
        public int StorageFileId { get; set; }
        public int TestId { get; set; }

        public virtual StorageFiles StorageFile { get; set; }
        public virtual Tests Test { get; set; }
    }
}