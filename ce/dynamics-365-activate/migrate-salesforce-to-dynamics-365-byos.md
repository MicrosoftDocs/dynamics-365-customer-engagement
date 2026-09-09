---
title: Set up your own storage and database for Dynamics 365 Activate (preview)
description: Learn how to configure bring your own storage (Azure Blob Storage) and bring your own database (Azure SQL Database) for Dynamics 365 Activate to keep migration data in your own Azure subscription.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Step 1: Set up your own storage and database for Dynamics 365 Activate (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Dynamics 365 Activate can keep your migration data in Azure resources that you own and control, instead of in Microsoft-managed storage. This feature is called bring your own storage (BYOS).

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

You have two options. These options are independent—you can use either, both, or neither.

| Option | What it holds | When to choose it |
|---|---|---|
| **Your own storage account (Azure Blob Storage)** | The record files that are staged while they move from Salesforce to Dataverse. Files are temporary and are cleaned up after a run. | Your policy requires migration payloads to stay inside your own subscription. |
| **Your own database (Azure SQL Database)** | Your project's discovery results, field mappings, and migration run history. Keep this data for the life of the project. | Your policy requires migration metadata and history to stay inside your own subscription. |

If you don't make a selection, your migration data stays in Microsoft-managed storage. You can skip the BYOS configuration steps in this article. You can set up BYOS at any time and move your migration data from Microsoft-managed storage.

> [!IMPORTANT]
> Set up bring your own storage before you connect Salesforce and run discovery. If you set up your own database after running discovery, you have to run discovery again and rebuild your mappings. Refer to [Recommended order](#recommended-order).

## Prerequisites

Before you begin, ensure that you have the following requirements in place:

- An Azure subscription. It doesn't have to be the same subscription or in the same region as your migration project.
- Permission to create a storage account, an Azure SQL Database, or both.
- Permission to change firewall and network rules on those resources.
- Access to the migration project in Dynamics 365 Activate. Only the project owner can connect or disconnect a project database.

## Choosing a region and subscription

Your storage account and your database don't have to be in the same region as your migration project, or even in the same Azure subscription. Azure Database Migration Service supports cross-region and cross-subscription setups.

Choose a region based on various factors:

| Factor | Consideration|
|---|---|
| **Data residency** | If your policy requires migration data to stay in a particular country/region, or geography, put your resources there, regardless of where the migration project runs. |
| **Speed** | The same region as your migration project is fastest. Choosing a different region is acceptable, but a large migration takes longer. |
| **Cost** | Moving data between regions incurs Azure bandwidth charges on your subscription. Staying in one region lowers cost. |

If you have no residency constraint, use the same region as your migration project. The two resources also don't have to be in the same region as each other, although keeping them together is simpler.

## Recommended order

Follow this order to avoid repeating work.

1. Create your Azure resources—storage account, database, or both.
1. Open your migration project and go to the **Configuration** tab.
1. Select **Start New Migration**. In the panel that opens, **Configure storage (BYOS)** is the first section.
    > [!NOTE]
    > If you don't see the **Configure storage (BYOS)** option, it isn't enabled for your environment yet. Contact your Microsoft representative.
1. Connect to your Azure Storage account.
1. Connect to your Azure SQL database.
1. Connect Salesforce and then connect Dynamics.
1. Run discovery.
1. Build your mappings and run the migration.

Steps 4 and 5 can be done in either order. Both must come before step 7.

> [!NOTE]
> If you already connected Salesforce and Dynamics, the button reads **Edit Connection** instead of **Start New Migration**. It opens the same panel.

## Part 1: Bring your own storage account

### What this covers

During a migration, you export records from Salesforce, write them to files, and then load them into Dataverse. When you bring your own storage account, you write those files to a container you own. The migration application removes the files from the container after the run finishes.

You don't store your discovery results and mappings here. Those live in the project database—see [Part 2: Bring your own database](#part-2-bring-your-own-database).

Because the storage account only holds records in transit, you can change or replace it at any time without losing any work.

### Step 1: Create a storage account

In the Azure portal, create a storage account with these settings.

| Setting | Value |
|---|---|
| **Performance** | Standard |
| **Redundancy** | Any. LRS is enough for migration staging. |
| **Account kind** | StorageV2 (general purpose v2) |
| **Hierarchical namespace** | Disabled (standard flat namespace) is recommended. |
| **Minimum TLS version** | 1.2 |
| **Region** | Any. See [Choosing a region and subscription](#choosing-a-region-and-subscription). |

### Step 2: Create the container

Create a blob container with the following name:

```text
migration-data
```

The name must match. The product looks for a container with this name and doesn't create it for you.

### Step 3: Create a SAS token

Generate a shared access signature (SAS) for the container.

1. Open the storage account and go to **Data storage** > **Containers**.
1. Select **migration-data**, and then select **Generate SAS**.
1. Set the permissions and options as follows.

   | Setting | Value | Why |
   |---|---|---|
   | **Permissions** | Read, Write, List, Delete | Read and Write move the records. List is used to reconcile what was transferred. Delete is used to clean up staged files after a run. |
   | **Start** | Now, or slightly in the past | A start time in the future makes the token unusable until it arrives. |
   | **Expiry** | Long enough to cover your migration, plus a margin | Migrations stop working the moment the token expires. |
   | **Allowed protocols** | HTTPS only | Plain HTTP is rejected. |
   | **Allowed IP addresses** | Leave blank | Restricting by IP blocks the migration service. |

1. Select **Generate SAS token and URL** and copy the **Blob SAS URL**.

The URL looks like this:

```text
https://<account>.blob.core.windows.net/migration-data?sp=rwdl&st=...&se=...&spr=https&sv=2024-11-04&sr=c&sig=...
```

> [!CAUTION]
> The SAS URL is a credential. Treat it like a password. Anyone holding it can read and write the container until it expires.

#### Choosing an expiry date

Pick an expiry that comfortably outlasts your migration. When a token is within seven days of expiring, the product warns you on the connection page. When it expires, migrations stop with an error telling you to generate a new token.

To replace a token, generate a new SAS and save the new URL over the old one. You don't need to perform any other steps.

### Step 4: Allow network access

The migration service must reach your storage account.

**Simplest option:** Under **Security + networking** > **Networking**, set public network access to **Enabled from all networks**. The SAS token controls access.

**If your policy doesn't allow that:** Use private connectivity instead—see [Optional: Private connectivity](#optional-private-connectivity). An IP allow list isn't a reliable alternative; migration data movement doesn't come from a single fixed address. Allow listing addresses on the storage firewall or on the SAS token blocks the transfer.

### Step 5: Save it in Dynamics 365 Activate

1. Open your migration project and go to the **Configuration** tab.
1. Select **Start New Migration**, or **Edit Connection** if your connections already exist.
1. Expand **Bring your own storage**.
1. Select **Use my own Azure Storage account**.
1. Paste the Blob SAS URL into **Storage SAS URL**.
1. Select **Save SAS URL**.
1. Select **Test connection**.

The test connection checks four things at once: the URL is well formed, the token is inside its validity window, the network path works, and the token really has permission on the migration-data container. A green **Connected** means a migration run passes its storage check too.

If the test succeeds but shows a warning, read it. Warnings predict failures that didn't happen yet - most often a token that is about to expire, or a permission that appears to be missing.

### Optional: Private connectivity

Use this feature only if your storage account must refuse public network access.

1. In the Azure portal, open your storage account and go to **Settings** > **Endpoints**. Copy the **Resource ID**.
1. In Dynamics 365 Activate, under **Bring your own storage**, find **Private connectivity**.
1. Paste the value into **Storage account resource ID** and save it. This value isn't a secret—it names the account but grants no access to it.
1. Select **Request private endpoint**. The status changes to **Waiting for your approval**.
1. Go back to the Azure portal, open your storage account, and go to **Security + networking** > **Networking** > **Private endpoint connections**.
1. Select the pending request shown in the product, and select **Approve**.
1. Return to Dynamics 365 Activate. The status changes to **Approved** on its own within a minute or two.

Once the status is **Approved**, you can set the storage account's public network access to **Disabled**.

> [!NOTE]
> The resource ID must name the same storage account as the SAS URL. If they differ, the request is refused—this prevents an approval request appearing in an unrelated subscription.

### Switching back to Microsoft-managed storage

To stop using your own storage account, select **Microsoft-managed storage** and then **Switch to Microsoft-managed storage**. Your saved SAS URL is removed from the project. Your storage account and its contents are left exactly as they are.

## Part 2: Bring your own database

### What this covers

Every migration project keeps a record of its own work: the objects and fields found during discovery, the mappings you build, and the history of each migration run. When you bring your own database, all of that information is written to an Azure SQL Database you own.

> [!IMPORTANT]
> Connect your database before you run discovery. Discovery results and mappings are written to whichever database is connected at the time. They don't move afterwards.

### Step 1: Create an Azure SQL Database

In the Azure portal, create a logical SQL server and a database on it.

| Setting | Value |
|---|---|
| **Server name** | Enter a meaningful server name. The full name ends in `.database.windows.net`. |
| **Database name** | Enter a name for your database. `migrationdb` is a reasonable choice. |
| **Service tier** | Any tier works. For a trial, a small General Purpose or Standard tier is enough. |
| **Collation** | Default |
| **Region** | Select the region where you want your database to be hosted. See [Choosing a region and subscription](#choosing-a-region-and-subscription). |

### Step 2: Enable SQL authentication

When you create the server, configure this setting on the **Authentication** page. For an existing server, go to **Settings** > **Microsoft Entra ID**. Make sure the server is set to:

**Use both SQL and Microsoft Entra authentication**

If the server is set to Microsoft Entra-only authentication, the product can't connect. It signs in with a username and password that you create and control.

### Step 3: Create a user for the product

Using SQL Server Management Studio, Azure Data Studio, or the portal query editor, connect to your migration database rather than the master database. Then run:

```sql
CREATE USER [migrationapp] WITH PASSWORD = '[a-strong-password]';
ALTER ROLE db_owner ADD MEMBER [migrationapp];
```

- Run these commands while connected to the migration database. They create a contained user that has access only to that database, not to other databases on the server.
- Assigning the `db_owner` role is the simplest option. For more limited permissions, assign the `db_ddladmin`, `db_datareader`, and `db_datawriter` roles instead. Together, these roles let the product create tables and read and write data.
- Create a strong, unique password and store it in a password manager.

### Step 4: Allow network access

Under **Security** > **Networking** on the SQL server, either:

- Turn on **Allow Azure services and resources to access this server**, or
- Add a firewall rule for the outbound address range of your Dynamics 365 Activate environment. Ask your Microsoft representative for the address if you need this.

Connections are always encrypted with TLS, and the server must present a valid certificate. You can't configure this setting.

### Step 5: Connect it in Dynamics 365 Activate

1. Open your migration project and go to the **Configuration** tab.
1. Select **Start New Migration**, or **Edit Connection** if your connections already exist.
1. Expand **Configure storage (BYOS)** and find **Project database**.
1. Select **Use my own Azure SQL database**.

   > [!WARNING]
   > A warning appears immediately. Read it before going further. It explains that you need to run again any discovery you already ran.

1. Fill in the connection fields.

   | Field | Example |
   |---|---|
   | **Server name** | `[your-server-name].database.windows.net` |
   | **Database name** | `migrationdb` |
   | **Username** | `migrationapp` |
   | **Password** | The password you set in step 3 |

1. Select **Test connection**. This action confirms the server is reachable, the sign-in works, and the user is allowed to create tables.
1. Select **Save**.
1. Select **Connect this database**.

### What happens when you connect

When you connect your database, Dynamics 365 Activate:

1. Creates the required tables in your database.
1. Copies the project name, settings, and member list to your database so that your project continues to work.
1. Stores all new discovery results, mappings, and run history only in your database.

Work you completed before you connected remains in Microsoft-managed storage and isn't copied to your database. If you previously ran discovery, run it again and rebuild your mappings.

If the connection fails, no changes are made. Your project continues to use its existing storage while you resolve the issue and try again.

### Switching back to Microsoft-managed database

Select **Microsoft-managed database**. Dynamics 365 Activate copies your project's name, settings, and member list to Microsoft-managed storage so that the project continues to work. Your database remains unchanged, and no data is deleted from it.

Discovery results and mappings you created while your database was connected remain there and aren't copied to Microsoft-managed storage. After switching, run discovery again and rebuild your mappings to continue with Microsoft-managed storage.

## Troubleshoot

### Storage account

| Message | What to do |
|---|---|
| Must use HTTPS | Regenerate the SAS with **HTTPS only** selected. |
| Host must be `<account>.blob.core.windows.net` | You copied a file, queue, or Data Lake URL. Use the Blob SAS URL from the container. |
| Missing SAS signature | You copied the container URL without the token. Copy the full Blob SAS URL, which includes everything after the `?`. |
| The storage SAS token has expired | Generate a new SAS and save the new URL over the old one. |
| The storage SAS token is not valid yet | The start time is in the future. Regenerate with a start time of now or earlier. |
| The SAS token might be missing these permissions | Regenerate with Read, Write, List, and Delete all selected. |
| Test connection fails with no clear reason | Confirm the container is named exactly `migration-data`, and that public network access is enabled or private connectivity is approved. |
| A warning about a private endpoint | Your account's address resolves somewhere the migration service might not reach. Either enable public network access, or set up private connectivity and approve the request. |

### Database

| Message | What to do |
|---|---|
| Server not found | Check the server name. It should be the full name ending in `.database.windows.net`. |
| Login failed | Check the username and password. Confirm you created the user inside the migration database, not in `master`, and that the server allows SQL authentication as well as Microsoft Entra. |
| Blocked by the server firewall | Turn on **Allow Azure services and resources to access this server**, or add the required firewall rule. |
| Timed out connecting | Almost always a firewall silently dropping the connection. Check the firewall rules. |
| The server accepted the login but the database could not be opened | Check the database name, and that this user has access to that database. |
| Connected, but this user cannot create tables | Grant `db_owner`, or at least `db_ddladmin`, then try again. |
| A password is required the first time you connect a database | Enter the password. You can only leave it blank when you're updating a connection that already has one saved. |
| Discovery fails saying results could not be saved | Your database became unreachable or read-only during discovery. Fix the connection, then run discovery again. Re-running is safe and completes the set. |

## Frequently asked questions

**Can I use my own storage account without using my own database, or vice versa?**
Yes. You can configure your own storage account and database independently.

**Do my Azure resources have to be in the same region or subscription as the migration project?**
No. Your resources can be in a different region or subscription. Using the same region can improve performance and avoid cross-region bandwidth charges. If your data residency policy requires a specific geography, use a region in that geography. For more information, see [Choosing a region and subscription](#choosing-a-region-and-subscription).

**Does Microsoft keep a copy of my data if I bring my own storage?**
No. After you connect your own storage, new data is written only to your resources. If your storage is unavailable, the operation fails and reports the reason instead of falling back to Microsoft-managed storage.

**Can I change the storage account later?**
Yes. You can change the storage account at any time because it holds records only while they're in transit.

**Can I change the database later?**
Yes, but discovery results and mappings aren't transferred to the new database. Run discovery again after changing the database.

**Who is allowed to change these settings?**
Anyone with admin or contributor access to the project can save or change the storage account. Only the project owner can connect, change, or disconnect the project database because it determines where the project's records are stored.

**What happens if my SAS token expires mid-migration?**
The migration run stops and reports that the token expired. Generate and save a new SAS token, and then restart the run.

**Do I need both a SAS token and a private endpoint?**
No. Most customers need only a SAS token. Use private connectivity only when the storage account must block public network access.

## Related information

- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
- [Security and data handling for Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-security.md)
- [Migration and verification](migrate-salesforce-to-dynamics-365-migration-verification.md)
