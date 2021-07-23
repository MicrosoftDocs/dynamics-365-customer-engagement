---
title: "Configure who knows whom (Sales Insights) | MicrosoftDocs"
description: "Configure who knows whom to help sellers quickly identify colleagues within their organization who can introduce them to leads or contacts."
ms.date: 08/10/2020
ms.custom: 
ms.topic: article
ms.assetid: c5e131e2-c4ba-4442-9580-dfc9badbc9ad
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
topic-status: Drafting
---

# Configure who knows whom

The who knows whom feature helps users to quickly identify colleagues within their organization who can introduce them to leads or contacts.

>[!NOTE]
><ul><li>Who knows whom is currently available in Europe, Middle East, and Africa (EMEA) and North American (NAM) regions.</li><li>For Office 365 data, you organization's data location must be in one of the following locations and not in your region-specific datacenter location:
> <ul><li>Global Geography 1 – EMEA (Austria, Finland, France, Ireland, Netherlands)</li><li>Global Geography 2 – Asia Pacific	(Hong Kong, Japan, Malaysia, Singapore, South Korea).</li><li>Global Geography 3 – Americas (Brazil, Chile, United States).</li></ul>More information: [Datacenter locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations)</ul>

To configure who knows whom, follow these steps:

1. Verify that advanced Sales Insights Add-in for Dynamics 365 features are enabled. More information: [Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)

2.	Go to **Change area** and select **Sales Insights settings**.

    > [!div class="mx-imgBorder"]
    > ![Select Sales Insights settings option](media/si-admin-change-area-sales-insights-settings.png "Select Sales Insights settings option")

3.  On the site map, select **Who knows whom** under **Connection insights**.

    > [!div class="mx-imgBorder"]
    > ![Who knows whom configuration page](media/si-admin-who-know-whom-configuration-page.png "Who knows whom configuration page")

4. On the **Who knows whom** section, select **Turn on Who Knows Whom for your organization**.

    > [!div class="mx-imgBorder"]
    > ![Enable who knows whom](media/si-admin-who-knows-whom-enable.png "Enable who knows whom")

5. Optionally, you can select an email template according to your organizational requirements. By default, an out-of-the-box email template will be selected.

6. Select **Save**.

The who knows whom feature is configured and ready to use in your organization.

## Enable the connection graph

After you enable the who knows whom feature in your organization, verify that the connection graph is enabled in the admin center. This allows [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] to collect the communication and collaboration details of users from Exchange server.

> [!NOTE]
> Contact your Microsoft 365 administrator to enable the Sales Insights connection graph if you don't have sufficient privileges to enable it.

To configure the Sales Insights connection graph, follow these steps:

1. Go to the **Admin** center.

    > [!div class="mx-imgBorder"]
    > ![Admin center](media/sales-insights-addon-admincenter.png "Admin center")

2. Select **Settings** > **Services & add-ins** > **Dynamics 365 Sales Insights – Connection Graph**.

    > [!div class="mx-imgBorder"]
    > ![Select the connection graph option](media/sales-insights-addon-admincenter-connection-graph-option.png "Select the connection graph option")

3.  Read the description carefully and then select the **Enable Dynamics 365 Sales Insights - Connection Graph for your entire organization**‎ option.

    > [!div class="mx-imgBorder"]
    > ![Enable and save the connection graph](media/sales-insights-addon-admincenter-connection-graph-enable.png "Enable and save the connection graph")

4. (Optional) If you don't want to collect information about a group of users in your organization, add their group ID in the text box. 

5. Select **Save**.

## Opt out of the connection graph

As a user, you can always choose to opt out of the connection graph if you don't want Sales Insights to analyze your communication and collaboration data. 

>[!NOTE]
>You can only opt out of the connection graph if your Office 365 organization is in the EMEA or Asia Pacific global geography. More information: [Datacenter locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide&preserve-view=true)

1. Sign in to your [Office 365 account](https://myprofile.microsoft.com/).

    > [!div class="mx-imgBorder"]
    > ![Sign in to your Office 365 account](media/sales-insights-addon-o365-account-settings.png "Sign in to your Office 365 account")

2. Select **Settings & Privacy**, and then select the **Privacy** tab. 

    > [!div class="mx-imgBorder"]
    > ![Open privacy settings](media/sales-insights-addon-o365-privacy-settings-tab.png "Open privacy settings")

3. In the **Services** section, select the arrow next to **Dynamics 365 Sales Insights - Connection Graph**.  

    > [!div class="mx-imgBorder"]
    > ![Expand the connection graph option](media/sales-insights-addon-o365-expand-connection-graph-settings.png "Expand the connection graph option")

4. Turn off the **Include my data** toggle.

    > [!div class="mx-imgBorder"]
    > ![Select toggle to opt out of the connection graph](media/sales-insights-addon-o365-opt-out-toggle.png "Select toggle to opt out of the connection graph")

After you opt out of the connection graph, Sales Insights won't analyze your data.

## Add the who knows whom widget to a form

By default, the who knows whom widget is available only in the out-of-the-box **Sales Insights** form. If you're using customized forms for leads and contacts, you can display the who knows whom widget on your custom forms by following these steps.

> [!IMPORTANT]
> - Adding the who knows whom widget is only supported in Unified Interface apps.
> - You can't use the legacy form designer to add a who knows whom widget to a form.

1. Sign in to the [Power Apps](https://make.powerapps.com/) portal.

    > [!div class="mx-imgBorder"]  
    > ![Power Apps home page](media/power-apps-home-page.png "Power Apps home page")

2. Search for and select your organization's environment.

    > [!div class="mx-imgBorder"]  
    > ![Select your organization](media/power-apps-select-org.png "Select your organization")

3. Select **Data** > **Tables**.

    The **Tables** page opens with the list of tables.

    > [!div class="mx-imgBorder"]  
    > ![Tables page with list of tables](media/power-apps-entities-page.png "Tables page with list of tables")

4. Open the table, select the **Forms** tab, and then select a main form to add the widget to. In this example, the table **Lead** is selected and the main form **Lead** is selected.

    >[!NOTE]
    >If you're unable to view the table to which you want to add the widget, in the upper-right corner of the page, change the filters settings to **All**.

    > [!div class="mx-imgBorder"]  
    > ![Select the Lead main form on the Forms tab](media/power-apps-lead-main-form.png "Select the Lead main form on the Forms tab")

5. In the form designer, select **Component**, and then from **Layout**, add a column to the form as a placeholder to add the widget.

    > [!div class="mx-imgBorder"]  
    > ![Add a column to the form](media/power-apps-layout-add-column-form.png "Add a column to the form")

6. From the site map, select **Display** > **Who Knows Whom**.

    >[!NOTE]
    >Ensure that the added placeholder column is selected. If it isn't, the widget will be added at a random place in the form. 

    > [!div class="mx-imgBorder"]  
    > ![Select the who knows whom widget](media/power-select-who-knows-whom-widget.png "Select the who knows whom widget")

8. In the **Edit who knows whom** pop-up window, select **Done**.

    > [!div class="mx-imgBorder"]  
    > ![Select Done to add the who knows whom widget](media/power-app-who-knows-whom-widget-options.png "Select Done to add the who knows whom widget")

    The who knows whom widget is added to the form, as shown in the following image.

    > [!div class="mx-imgBorder"]  
    > ![Who knows whom widget added to the form](media/power-app-who-knows-whom-widget-added.png "Who knows whom widget added to the form")

    >[!NOTE]
    >To hide the **New section** label, go to the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.

9. Save and publish the form.

### See also

[Get introduced to a lead](../sales/who-knows-whom.md)  
[Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
