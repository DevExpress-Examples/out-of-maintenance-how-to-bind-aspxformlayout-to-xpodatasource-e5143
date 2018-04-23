using System;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;

/// <summary>
/// Summary description for XpoHelper
/// </summary>
public static class XpoHelper {
    public static Session GetNewSession() {
        return new Session(DataLayer);
    }

    public static UnitOfWork GetNewUnitOfWork() {
        return new UnitOfWork(DataLayer);
    }

    private readonly static object lockObject = new object();

    static volatile IDataLayer fDataLayer;
    static IDataLayer DataLayer {
        get {
            if (fDataLayer == null) {
                lock (lockObject) {
                    if (fDataLayer == null) {
                        fDataLayer = GetDataLayer();
                    }
                }
            }
            return fDataLayer;
        }
    }

    private static IDataLayer GetDataLayer() {
        // set XpoDefault.Session to null to prevent accidental use of XPO default session
        XpoDefault.Session = null;

        string conn = MSSqlConnectionProvider.GetConnectionString(@"(local)", "XpoWebTest");
        XPDictionary dict = new ReflectionDictionary();

        /* Note: The database schema must exactly match your persistent classes' definition. ASP.NET applications
         * should not update the database schema themselves; moreover, they often don't have enough permission
         * to read the database schema.  You may need to create a separate tool which manages your database.
         * On the one hand, we recommend using AutoCreateOption.SchemaAlreadyExists for the XPO data layer of your
         * Web site.  On the other hand, the ThreadSafeDataLayer intensively uses data which is stored in the XPO's
         * XPObjectType service table.  This sample project maps to the XpoWebTest database on your MS SQL Server.
         * This database is created via the DatabaseUpdater project, which must be launched before this Site is 
         * published. */

        IDataStore store = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema);

        // initialize the XPO dictionary
        dict.GetDataStoreSchema(typeof(PersistentObjects.Customer).Assembly);

        // create a ThreadSafeDataLayer
        IDataLayer dl = new ThreadSafeDataLayer(dict, store);

        return dl;
    }
}
