using Oxide.Core.Plugins;
using System.Data.SQLite;

namespace Oxide.Ext.SQLite
{
    public sealed class Connection
    {
        internal string ConnectionString { get; set; }
        internal bool ConnectionPersistent { get; set; }
        internal SQLiteConnection Con { get; set; }
        internal Plugin Plugin { get; set; }
        public long LastInsertRowId { get; internal set; }

        public Connection(string connection, bool persistent)
        {
            ConnectionString = connection;
            ConnectionPersistent = persistent;
        }
    }
}
