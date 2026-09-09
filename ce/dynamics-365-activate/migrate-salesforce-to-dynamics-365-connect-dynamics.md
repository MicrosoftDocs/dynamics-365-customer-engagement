---
title: Connect to Dynamics 365 and run discovery (preview)
description: Learn how to create a Microsoft Entra app registration, set up a Dataverse application user, connect Dynamics 365 Activate to your environment, and verify target discovery.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zobanyai
ai-usage: ai-assisted
---

# Step 3: Connect to Dynamics 365 and run discovery (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Dynamics 365 Activate uses a Microsoft Entra app registration and a Microsoft Dataverse application user to connect to your environment. You can use this connection for target discovery and migration.

During target discovery, Dynamics 365 Activate reads metadata, relationships, choices, solutions, and record counts from Dataverse. During migration, it can import schema customizations and create or update mapped records. The application user's permissions control which operations Dynamics 365 Activate can perform.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you begin, make sure that you have:

- Permission to enter and store the tenant ID, client ID, and client secret in Dynamics 365 Activate.
- A plan for the tables and workloads that you intend to migrate, so you can assign only the required table privileges.

> [!NOTE]
> The Microsoft Entra app registration and the Dataverse environment must belong to the same tenant.

## How the connection works

Dynamics 365 Activate connects by using the **OAuth 2.0 client credentials flow**. Microsoft Entra ID authenticates the app registration, and Dataverse authorizes its requests through the corresponding application user.

This connection doesn't require an interactive user account or store a user password.

| Component | Purpose |
|---|---|
| **Microsoft Entra app registration** | Identifies Dynamics 365 Activate and supplies the client ID. |
| **Client secret** | Allows Microsoft Entra ID to authenticate the app registration. |
| **Dataverse application user** | Represents the app registration in the Dataverse environment. |
| **Security roles** | Control which metadata, tables, and records the application user can read or modify. |
| **Environment URL** | Identifies the target Dataverse environment and OAuth resource. |

You can add the same app registration as an application user in multiple Dataverse environments. You must assign its security roles separately in each environment.

## Configure least-privilege access

Use **System Customizer** as the baseline role. This role provides the customization privileges required to discover Dataverse metadata and import schema customizations without granting the broader System Administrator role.

System Customizer doesn't automatically provide all create, read, write, append, or append-to privileges for every standard application table. Add narrowly scoped custom roles for the tables and workloads that you migrate.

| Workload | Required access |
|---|---|
| Test connection | Access to the environment as an application user. |
| Target metadata discovery | System Customizer. |
| Record-count discovery | Read access to each table being counted. |
| Solution import and schema creation | System Customizer. |
| Data migration | Create, Read, Write, Append, and Append To privileges as required by each target table and its relationships. |
| Ownership and sharing migration | Additional privileges for users, teams, business units, security roles, queues, assignment, and sharing operations used by the selected workload. |

> [!NOTE]
> Don't grant System Administrator only to resolve a missing table privilege. Add the reported privilege to a workload-specific custom role and assign that role to the application user.

## Find the environment URL

1. Go to the [Power Platform admin center](https://admin.powerplatform.microsoft.com).
1. Select **Manage** > **Environments**.
1. Select the target environment.
1. Copy the **Environment URL** from the environment details.
1. Remove any path, query string, or trailing slash.

Environment URLs use formats similar to:

```text
https://contoso.crm.dynamics.com
https://contosotest.crm10.dynamics.com
```

If you copy a model-driven app URL such as `https://contoso.crm.dynamics.com/main.aspx?appid=00000000-0000-0000-0000-000000000000`, enter only the origin: `https://contoso.crm.dynamics.com`.

## Create the Microsoft Entra app registration

1. Go to the [Microsoft Entra admin center](https://entra.microsoft.com).
1. Confirm that you're signed in to the tenant that owns the target Dataverse environment.
1. Go to **Identity** > **Applications** > **App registrations**.
1. Select **New registration**.
1. Enter a recognizable name, such as **Dynamics 365 Activate**.
1. Under **Supported account types**, select **Accounts in this organizational directory only**.
1. Leave **Redirect URI** blank.
1. Select **Register**.

> [!NOTE]
> Client Credentials flow doesn't use a redirect URI or delegated user permissions.

## Copy the application and tenant IDs

On the app registration **Overview** page, copy these values:

| Microsoft Entra field | Dynamics 365 Activate field |
|---|---|
| **Application (client) ID** | Client ID |
| **Directory (tenant) ID** | Tenant ID |

Both values are GUIDs. You don't use the Object ID to configure the connection.

## Create a client secret

1. In the app registration, select **Certificates & secrets**.
1. Select **Client secrets** > **New client secret**.
1. Enter a description, such as **Dynamics 365 Activate**.
1. Select an expiration period that complies with your organization's credential policy.
1. Select **Add**.
1. Immediately copy the secret from the **Value** column.

> [!IMPORTANT]
> The client secret value is shown only once. Copy the **Value**, not the **Secret ID**. If you leave the page without copying the value, create a new client secret.

> [!CAUTION]
> Store the client secret securely. Don't include it in email, support tickets, screenshots, or documentation. Record its expiration date and rotate it before it expires.

## Create the Dataverse application user

The app registration must have a corresponding application user in the target environment.

1. Go to the [Power Platform admin center](https://admin.powerplatform.microsoft.com).
1. Select **Manage** > **Environments**, and then select the target environment.
1. Select **Settings** > **Users + permissions** > **Application users**.
1. Select **New app user**.
1. Select **Add an app**.
1. Search for the application by name or client ID, select it, and then select **Add**.
1. Select the root business unit unless your environment's security design requires another business unit.
1. Select **Edit security roles**.
1. Assign **System Customizer**.
1. Assign any workload-specific custom roles required for the tables that you plan to migrate.
1. Select **Create**.

An application user is non-interactive and doesn't require a Dynamics 365 user license.

### Add privileges for knowledge article migration

Migrating Salesforce knowledge objects (`Knowledge__kav`) to the Dataverse **Knowledge Article** table requires privileges that System Customizer doesn't include.

Create a custom security role, such as **Dynamics 365 Activate Knowledge**, and grant the following privileges at the organization level:

| Table | Privileges |
|---|---|
| **Knowledge Article** | Create, Read, Write, Append, Append To |
| **Language Locale** | Read |

Assign this role to the same application user in addition to System Customizer. Dynamics 365 Activate creates article versions and translations and applies Draft, Published, or Archived states.

> [!NOTE]
> An error that contains **missing prvCreateKnowledgeArticle privilege** means that the application user is missing Create access to the Knowledge Article table. The **Non-interactive access mode** shown in the error is expected and isn't the cause.

## Connect Dynamics 365 Activate

1. Open Dynamics 365 Activate.
1. Open your migration project.
1. On the **Configuration** page, find **Dynamics Configuration**.
1. In **Environment URL**, enter the URL from the target environment.
1. In **Tenant ID**, enter the Directory (tenant) ID.
1. In **Client ID**, enter the Application (client) ID.
1. In **Client Secret**, enter the client secret value.
1. Save the Dynamics configuration.
1. Select **Test Connection**.

A successful test displays **Successfully connected to Dynamics** and returns the Dataverse user ID and organization ID.

## Verify target discovery

After the connection succeeds:

1. Run Dynamics discovery for the migration project.
1. Review the discovered tables, columns, relationships, and global choices.
1. Confirm that expected standard and custom tables are present.
1. Compare the organization ID returned by the connection test with the intended target environment.
1. Review missing record counts or permission errors before you generate mappings or import a solution.

Missing tables or columns can indicate that the application user lacks metadata access or that a component isn't present in the selected environment. Missing record counts usually indicate missing Read access to the corresponding table.

## Dataverse API operations used

Dynamics 365 Activate uses the Dataverse Web API version 9.2.

### Authentication and connection test

| Operation | Purpose |
|---|---|
| `POST https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token` | Obtains an application token by using `grant_type=client_credentials` and the Dataverse `/.default` scope. |
| `GET /api/data/v9.2/WhoAmI` | Confirms the connection and returns the Dataverse user and organization IDs. |

### Target discovery

| Operation | Purpose |
|---|---|
| `GET /api/data/v9.2/EntityDefinitions` | Reads table metadata and capabilities. |
| `GET /api/data/v9.2/EntityDefinitions(...)/Attributes` | Reads columns, data types, requirements, and choices. |
| `GET /api/data/v9.2/RelationshipDefinitions/...` | Reads one-to-many and many-to-many relationships. |
| `GET /api/data/v9.2/GlobalOptionSetDefinitions` | Reads global choices. |
| `GET /api/data/v9.2/solutions` | Reads installed solution information. |
| `GET /api/data/v9.2/{table}/$count` | Reads table record counts when the application user has access. |

### Schema and data migration

Migration uses Dataverse Web API metadata and data operations to import solutions, publish customizations, and create or update mapped records. The exact table operations depend on the approved migration contract and selected workloads.

Dynamics 365 Activate doesn't keep an open Dataverse session. It requests an access token when an operation requires Dataverse access.

## Rotate or remove access

### Rotate the client secret

1. Create a new client secret in the Microsoft Entra app registration.
1. Update the **Client Secret** in Dynamics 365 Activate.
1. Test the connection.
1. Delete the previous secret after the new connection succeeds.

### Remove access

When you no longer need the connection:

1. Remove the application user from the Dataverse environment, or remove its security roles.
1. Delete the client secret from the Microsoft Entra app registration.
1. Delete the app registration if no other approved workload uses it.
1. Remove the Dynamics credentials from Dynamics 365 Activate.
1. Use **Delete all my data** in Dynamics 365 Activate when you want to remove your projects and stored migration information.

## Troubleshoot Dynamics 365 connection issues

### Application with identifier wasn't found in the directory

**Cause:** The client ID doesn't identify an app registration in the tenant specified by the tenant ID.

**Resolution:** Copy the Application (client) ID and Directory (tenant) ID again from the app registration **Overview** page. Confirm that the app registration and Dataverse environment are in the same tenant.

### AADSTS700016: Application wasn't found

**Cause:** The client ID is incorrect, the app registration was deleted, or the request was sent to the wrong tenant.

**Resolution:** Verify the client ID and tenant ID. If the app registration was deleted, create a new app registration and application user.

### Invalid client secret or AADSTS7000215

**Cause:** You entered the Secret ID instead of the secret Value, copied the value incorrectly, or the secret expired.

**Resolution:** Create a new client secret, copy its **Value**, update Dynamics 365 Activate, and test the connection again.

### Unauthorized client or HTTP 401

**Cause:** Authentication failed, or the app registration doesn't have a usable application user in the selected Dataverse environment.

**Resolution:** Verify the tenant ID and secret. In the Power Platform admin center, confirm that the application user exists in the target environment and is enabled.

### HTTP 403 or missing privilege

**Cause:** Authentication succeeded, but the application user's security roles don't authorize the requested operation.

**Resolution:** Identify the missing Dataverse privilege in the error. Add that privilege at the required access level to a workload-specific custom role, and assign the role to the application user.

### Incomplete Dynamics credentials

**Cause:** One or more required connection fields are empty.

**Resolution:** Enter the Environment URL, Tenant ID, Client ID, and Client Secret. Remove leading or trailing spaces.

### The environment URL isn't accepted

**Cause:** The URL contains a model-driven app path, query string, unsupported host, or a different environment.

**Resolution:** Copy the Environment URL from the Power Platform admin center and enter only the HTTPS origin, such as `https://contoso.crm.dynamics.com`.

### The connection worked before but stopped

**Cause:** The client secret expired, the application user was removed or disabled, its security roles changed, or the environment was reset.

**Resolution:** Check the secret expiration date and application-user configuration. Environment copy, restore, and reset operations can require you to recreate or reconfigure the application user.

### Target discovery is incomplete

**Cause:** The application user lacks metadata or table Read privileges, or the expected solution isn't installed in the selected environment.

**Resolution:** Confirm that System Customizer and the required custom roles are assigned. Verify that you connected to the intended environment and that the expected applications and solutions are installed.

## Related information

- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Object mapping](migrate-salesforce-to-dynamics-365-object-mapping.md)
- [Solution deployment](migrate-salesforce-to-dynamics-365-solution-deployment.md)
- [Clean up after a Salesforce migration](migrate-salesforce-to-dynamics-365-cleanup.md)
