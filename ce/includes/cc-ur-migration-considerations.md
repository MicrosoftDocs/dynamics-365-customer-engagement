To troubleshoot any issues that you might face during migration, do the following:

- During the import of the data in the target organization, if you see yellow warning symbols, we recommend that you verify the following logs in the Configuration Migration Tool:

    - **Login_ErrorLog.log**: Provides information about any issues you had when you signed int to the organization using the Configuration Management Tool.
    - **DataMigrationUtility.log**: Provides information about the tasks performed using the tool during the last migration.
    - **ImportDataDetail.log**: Provides information about the data imported by the tool in the last data import. 

    More information: [Troubleshoot configuration data migration issues using log files](/power-platform/admin/manage-configuration-data#troubleshoot-configuration-data-migration-issues-using-log-files)

- If the logs contain network errors, then repeat the import process.

    :::image type="content" source="../customer-service/media/yellow-warnings-in-data-import.png" alt-text="Yellow warnings that indicate errors during data import.":::

    Here's an example:
    ```
    Time: 11:46:09 PM
    Error: There was no endpoint listening at `https://www.contoso.com/XRMServices/2011/Organization.svc/web?SDKClientVersion=9.2.46.5279` that could accept the message. This is often caused by an incorrect address or SOAP action. See InnerException, if present, for more details.
    Stack Trace: Service stack trace:
    ```
