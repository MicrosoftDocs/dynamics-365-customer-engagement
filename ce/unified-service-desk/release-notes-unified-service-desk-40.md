---
title: "Release notes of Unified Service Desk 4.0 (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the known issues in Unified Service Desk."
keywords: ""
ms.date: 08/03/2018
ms.service:
  - "usd"
ms.custom:
  - ""
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 8DD75956-F421-445D-ACC2-7687696BEF5F
author: kabala123
ms.author: kabala
manager: Shujoshi
---

# Release notes of Unified Service Desk 4.0

This section describes the known issues and limitations in [!INCLUDE[pn-unified-service-desk-4-0](../includes/pn-unified-service-desk-4-0.md)]

## Known issues in Unified Service Desk

This section describes the limitations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

### Toolbar shows Unified Blue theme instead Air theme

In the **Unified Interface Settings** record, select **Air** theme instead **Unified Blue** theme, and select an Unified Interface App. 

![Air theme is set in the Unified Interface Settings record](media/usd-crm-unified-interface-air-theme.png "Air theme is set in the Unified Interface Settings record")

Now, if you login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], the **About Tool Bar** and **Main** toolbar chooses to show **Unified Blue** theme colors instead **Air** theme.

![The main and about toolbar is not picking Air theme colors instead show Unified Interface theme colors](media/about-toolbar-main-toolbar-known-issue.png "The main and about toolbar is not picking Air theme colors instead show Unified Interface theme colors")

#### Workaround

Remove the **Custom Styles** XAML from the **About Tool Bar** and **Main** toolbar so that toolbar picks the **Air** theme colors.

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]

2. Go to **Settings** > **My Apps** > **Unified Service Desk Administrator** app.<br>

3. Select **Site Map**.</br>
![Select Site Map to go to Unified Interface Settings](media/usd-crm-site-map-unified-interface-setting.PNG "Select Site Map to go to Unified Interface Settings")

4. Choose **Toolbars** under the **Basic Settings**.

5. Select **About Tool Bar** from the list.

6. Choose the **Styles** tab.

7. Remove the content in the **Custom Styles** field.

8. Select **Save** to save the settings. 

Repeat the steps 5-8 for the **Main** toolbar.

Login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] and toolbar chooses **Air** theme colors.

## Limitations in Unified Service Desk

This section describes the limitations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]



## See also

