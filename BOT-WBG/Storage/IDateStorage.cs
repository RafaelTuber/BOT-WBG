using System;
using System.Collections.Generic;
using System.Text;

namespace BOT_WBG.Storage
{
    public interface IDateStorage
    {
        void StoreObject(object obj, string key);

        T RestoreObject<T>(string key);
    }
}