---
title: Connect to Salesforce and run discovery (preview)
description: Learn how to set up a Salesforce External Client App, configure a least-privilege integration user, connect Dynamics 365 Activate to your Salesforce org, and run discovery.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zobanyai
ms.collection: bap-ai-copilot
---

# Step 2: Connect to Salesforce and run discovery (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article explains how to configure a least-privilege Salesforce connection for Dynamics 365 Activate, connect the application to your Salesforce org, and run discovery to generate a migration readiness assessment.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Discovery reads metadata and aggregate information about objects, fields, automation, custom code, security, integrations, and data volume. It doesn't create, update, or delete Salesforce records, or deploy Salesforce configurations. Migration is a separate process that reads the records selected in your migration project and writes the mapped records to Microsoft Dataverse.

## Prerequisites

Before you begin, make sure that you have:

- Salesforce administrator access, or equivalent access to create an External Client App, configure OAuth policies, and assign permission sets.
- Permission to enter and store the External Client App consumer key and consumer secret in Dynamics 365 Activate.

> [!NOTE]
> The integration user doesn't need the System Administrator profile. Assign only the permissions and object access needed for the discovery scope.

## How the connection works

Dynamics 365 Activate uses the **OAuth 2.0 Client Credentials flow**. The External Client App authenticates as one Salesforce **Run As** user without an interactive sign-in or a stored user password.

The Run As user's permissions determine which metadata, objects, fields, and records discovery can read.

| Component | Purpose |
|---|---|
| **External Client App** | Registers Dynamics 365 Activate as an OAuth client and provides the consumer key and consumer secret. |
| **Run As user** | Provides the Salesforce identity used for every discovery API call. |
| **Permission sets** | Define the metadata, schema, and record data that discovery can read. |
| **My Domain URL** | Provides the org-specific OAuth token endpoint required by the Client Credentials flow. |

## Create the integration user and configure least-privilege access

Create a dedicated Salesforce user for discovery instead of using an administrator's personal account. Use separate permission sets for system-level discovery permissions and object or field read access so that access is easier to review and maintain.

1. In Salesforce Setup, create or select an active user to serve as the integration user. Use a recognizable name such as **D365 Migrate Integration**.

1. Assign a profile that permits API access.
1. Create a permission set for system-level discovery and add the following Salesforce system permissions:

    | System permission | Why it is needed |
    |---|---|
    | **API Enabled** | To enable all discovery operations. |
    | **View Setup and Configuration** | To read setup information such as object definitions, record types, profiles, permission sets, roles, licenses, and organization settings. |
    | **Customize Application** | To read configuration metadata such as page layouts, workflow rules, validation rules, approval processes, sharing rules, and matching rules. |
    | **Modify Metadata Through Metadata API Functions** | To allow the application to call the Metadata API. Salesforce doesn't provide a separate read-only permission for these API calls. |
    | **Author Apex** | To read Apex class and trigger source code and code coverage information. |
    | **Manage Flow** | To read Flow and Process Builder definitions. |
    | **View All Data** | Optional. To allow aggregate assessment across all records the user can access. Use object-level Read access instead when discovery must be limited to selected objects. |

1. Add any optional system permissions required for the intended discovery scope:
   - Use **Manage Users** when you need complete detail about users and the security model.
   - Use **Manage Connected Apps** when connected app discovery requires information that **View Setup and Configuration** doesn't expose.
1. Create a separate permission set for object and field access. For every object included in discovery:
   1. Grant **Read** access to the object.
   1. Grant **Read** access to the fields that discovery should assess.
   1. Grant record access through sharing, object permissions, or **View All Data**, depending on the intended scope.
1. Assign feature-specific permission set licenses only when you need to discover licensed industry or platform features.
1. Confirm that the user isn't frozen or locked, and keep the account active while discovery or migration operations are running.

> [!NOTE]
>-Permissions such as **Modify Metadata Through Metadata API Functions** and **Author Apex** have names that imply write access. Dynamics 365 Activate uses them only to call Salesforce read and list operations. The discovery service doesn't issue metadata create, update, delete, or deploy requests.
>- System permissions don't replace object-level security or field-level security. Salesforce filters describe results through field-level security. A user can have **View All Data** and still see only part of an object's schema when field permissions are missing.

## Get the Salesforce My Domain URL

The Client Credentials flow requires the org-specific My Domain host. Don't use `https://login.salesforce.com`, `https://test.salesforce.com`, or a Lightning Experience URL.

1. In Salesforce Setup, search for **My Domain**.
1. Open **My Domain**.
1. Copy the current My Domain URL.
1. Remove any path after the host name.

**Examples of valid My Domain URLs:**

```text
https://contoso.my.salesforce.com
https://contoso--uat.sandbox.my.salesforce.com
```

If you copy a full browser URL such as `https://contoso--uat.sandbox.my.salesforce.com/lightning/setup/SetupOneHome/home`, enter only the host: `https://contoso--uat.sandbox.my.salesforce.com`.

## Create the External Client App

Salesforce External Client Apps are the current app model for new OAuth integrations.

1. In Salesforce Setup, search for **External Client App Manager**.
1. Select **New External Client App**.
1. Enter an app name, such as **D365 Migrate Discovery**.
1. Set the distribution state to **Local**.
1. Enter a contact email address, and then save the app.
1. Open the app's **Settings** tab.
1. Under **OAuth Settings**, enable OAuth.
1. Enter a valid HTTPS callback URL. The Client Credentials flow doesn't redirect to this URL, but Salesforce requires a value. For example, enter `https://login.salesforce.com/services/oauth2/callback`.
1. Add the **Manage user data via APIs (api)** OAuth scope.
1. Under flow enablement, enable **Client Credentials Flow**, and then save the settings.

> [!NOTE]
> Don't add the **Full access (full)** scope unless another approved use of the app requires it. The API scope is sufficient for Dynamics 365 Activate discovery.

## Assign the Run As user

1. In **External Client App Manager**, open the app.
1. Open **Policies**.
1. Under **OAuth Policies**, find the Client Credentials flow settings.
1. Select the dedicated integration user as the **Run As** user.
1. Save the policy.

> [!TIP]
> If Salesforce continues to report that no Client Credentials user is enabled, turn the flow off, save the app, and then enable it again with the Run As user selected.

## Copy the consumer credentials

1. Open the External Client App.
1. Go to **Settings** > **OAuth Settings**.
1. Open **Consumer Key and Secret**.
1. Complete identity verification if Salesforce requests it.
1. Copy the **Consumer Key** and the **Consumer Secret**.

The Consumer Key is the Client ID. The Consumer Secret is the Client Secret.

> [!CAUTION]
> Store the Consumer Secret securely. Don't include it in email, support tickets, screenshots, or documentation. If you suspect that the secret was exposed, regenerate it in Salesforce and update Dynamics 365 Activate.

## Enter Salesforce credentials in the application

1. Open Dynamics 365 Activate and navigate to your project.
1. On the **Configuration** tab, select **Start New Migration**.
1. Enter:
   - **Login URL**: Your org-specific My Domain URL (for example, `https://contoso.my.salesforce.com`). Don't use `https://login.salesforce.com` or `https://test.salesforce.com`.
   - **Consumer Key (Client ID)**: The Consumer Key copied from the External Client App.
   - **Consumer Secret (Client Secret)**: The Consumer Secret copied from the External Client App.
1. Select **Save Salesforce Credentials**.
1. Select **Test Connection**.

A successful test confirms that Salesforce issued an access token and that the Run As user can call the Salesforce API.

## Run Salesforce discovery

After the connection succeeds, run discovery to scan your Salesforce org's metadata.

1. In the sidebar, select **Discovery**.  
   The discovery landing page shows all available categories as cards. 
1. Select **Discover** on each card to scan that category.

   > [!TIP]
   > You can run multiple discovery categories simultaneously. Start with **Objects & Relationships** as a foundation for other analysis.

### Discovery categories

| Category | What it discovers |
|---|---|
| **Objects & Relationships** | Custom and standard objects, fields, relationships, dependency chains, migration waves |
| **Flows & Automation** | Flows, Process Builder processes, complexity scores, migration readiness |
| **Apex Code** | Classes, triggers, cyclomatic complexity, migration recommendations |
| **Business Processes** | Workflow rules, field updates, approval processes, Copilot Studio opportunities |
| **Lightning Pages** | FlexiPages, Lightning components, Dynamics 365 app recommendations |
| **ISV Packages** | Installed managed packages with Microsoft ecosystem alternatives |
| **Integrations** | Connected apps, named credentials, external data sources, platform events |
| **Localization & Currency** | Languages, translations, multi-currency configuration |
| **Licenses & Users** | License types, user profiles, usage patterns |
| **Usage & Tech Debt** | Low-usage objects and fields, inactive automations, cleanup opportunities |

### Verify discovery results

After each discovery category finishes:

1. Review the discovered object and field counts.
1. Compare key objects with an administrator's view in Salesforce.
1. Review any discovery areas that appear empty or incomplete.

Missing objects or fields usually indicate missing object Read access, field-level Read access, or a feature permission set license. An empty discovery area can indicate that a required system permission wasn't assigned. See [Discovery permissions by area](#discovery-permissions-by-area).

- **Objects & Relationships**: Use the **Graph view** to understand dependencies and the **Table view** to review field details. Filter by package type (Standard, Custom, ISV).
- **Flows & Automation**: Review complexity scores and migration readiness labels such as **Ready**, **Requires Review**, or **Manual Migration**.
- **Apex Code**: Focus on custom classes (managed package classes are automatically filtered out). Review complexity scores and migration recommendations.
- **ISV Packages**: Identify third-party packages and review Microsoft ecosystem alternatives.
- **Usage & Tech Debt**: Review objects and fields recommended for exclusion from migration scope to reduce complexity.

### Download the assessment report

1. On the **Discovery** tab, select **Download PDF Report**.

The report includes complexity scores, migration readiness ratings, recommended approaches, and transformation recommendations. This report is suitable for sharing with stakeholders and project teams.

## Discovery permissions by area

| Discovery area | Salesforce access used |
|---|---|
| Objects, fields, relationships, and record types | **API Enabled**, **View Setup and Configuration**, object Read, and field-level Read |
| Record counts, dates, and field fill rates | Record Read access or **View All Data** |
| Apex classes, triggers, and code coverage | **Author Apex** and **View Setup and Configuration** |
| Flows and Process Builder | **Manage Flow** and **View Setup and Configuration** |
| Workflow rules, validation rules, layouts, approvals, and sharing rules | **Customize Application** and **Modify Metadata Through Metadata API Functions** |
| Profiles, permission sets, roles, and organization-wide defaults | **View Setup and Configuration**; **Manage Users** for complete detail |
| Connected apps, named credentials, and external data sources | **View Setup and Configuration**; **Manage Connected Apps** when required |

## Salesforce API operations used during discovery

Dynamics 365 Activate uses Salesforce API version 59.0. The service uses only read, describe, query, and metadata list or read operations. Discovery doesn't use Salesforce create, update, delete, or deploy operations.

| API | Operations |
|---|---|
| **Authentication** | `POST /services/oauth2/token` — obtains an access token with `grant_type=client_credentials` |
| **REST API** | Lists available objects. Describes fields, data types, relationships, and picklist values. Reads layouts, record counts, and SOQL aggregate assessment data. |
| **applicationing API** | Reads Apex classes, triggers, validation rules, flows, Lightning pages, connected apps, named credentials, external data sources, and platform event channel members |
| **Metadata API** | Lists or reads layouts, assignment rules, approval processes, workflow rules, sharing rules, and Flow definitions. |

## Troubleshoot Salesforce connection issues

### Request isn't supported on this domain

**Cause:** The sign-in URL is `login.salesforce.com`, `test.salesforce.com`, or a Lightning URL.

**Resolution:** Enter the org-specific My Domain URL, such as `https://contoso.my.salesforce.com` or `https://contoso--uat.sandbox.my.salesforce.com`.

### No Client Credentials user is enabled

**Cause:** Client Credentials flow isn't enabled, or the Run As policy wasn't saved.

**Resolution:** Open the External Client App's OAuth policies, enable Client Credentials flow, select the Run As user, and save the policy.

### Invalid client or invalid client credentials

**Cause:** The Consumer Key or Consumer Secret is incorrect or no longer valid.

**Resolution:** Copy the credentials again from the External Client App. If necessary, regenerate the Consumer Secret and update the connection in Dynamics 365 Activate.

### Invalid grant or authentication failure

**Cause:** The Run As user is inactive, frozen, locked, or blocked by an app or network policy.

**Resolution:** Verify the user status and review the External Client App policies, authentication restrictions, and IP settings.

### Fewer objects or fields are discovered than expected

**Cause:** The Run As user is missing object Read or field-level Read access for some objects.

**Resolution:** Update the object and field read-permissions set. Note that **View All Data** doesn't grant field visibility—field-level Read permissions are required separately.

### A discovery area is empty

**Cause:** The Run As user is missing a system permission required by that Salesforce API.

**Resolution:** Review [Discovery permissions by area](#discovery-permissions-by-area) and assign the corresponding permission to the integration user.



## Related information

- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
- [Object mapping](migrate-salesforce-to-dynamics-365-object-mapping.md)
- [Clean up after a Salesforce migration](migrate-salesforce-to-dynamics-365-cleanup.md)
- [OAuth 2.0 Client Credentials Flow for Server-to-Server Integration](https://help.salesforce.com/s/articleView?id=xcloud.remoteaccess_oauth_client_credentials_flow.htm&type=5)
- [External Client Apps](https://help.salesforce.com/s/articleView?id=xcloud.external_client_apps.htm&type=5)
