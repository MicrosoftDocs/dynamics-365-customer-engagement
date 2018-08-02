---
title: "Use Power BI with Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 48997010-a47c-4e16-b7d2-f55d7a52ba19
caps.latest.revision: 36
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Use Power BI

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

The [!INCLUDE[pn_power_bi_for_office_365_long](../includes/pn-power-bi-for-office-365-long.md)] cloud service works with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to provide a self-service analytics solution. [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] automatically refreshes the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] data displayed. With [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)] or [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] Power Query for authoring reports and [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] for sharing dashboards and refreshing data from [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], sales, marketing, and service personnel in your organization have a powerful new way to work with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data.  
  
<a name="PowerBIGetstarted"></a>   
## Get started using Power BI with Dynamics 365 (online)  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] content packs for [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] cloud service allow you to easily access and analyze your sales, service, or marketing data.  
  
 To create a [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] dashboard using a  content pack, follow these instructions.  
  
1. If you haven't already done so, [register with Power BI](http://powerbi.com/).  
  
2. After you have signed in to [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)], in the **Datasets** area click **Get Data**, under **Services** click **Get**, and then select from the following content packs.  
  
   - **Dynamics 365 (online) Sales Manager**  
  
   - **Dynamics 365 (online) Service Manager**  
  
   - **Dynamics Marketing**  
  
3. For the Sales Manager and Service Manager content packs, enter the URL of your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instance, such as *<https://OrganizationName.crm.dynamics.com>*, where *OrganizationName* is the organization name of your instance of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], and click **Next**.  
  
   > [!NOTE]
   >  If your data center is outside of North America the crm.dynamics.com domain name may be different, such as crm2.dynamics.com, crm3.dynamics.com, crm4.dynamics.com, etc. To find the domain name, in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web app go to **Settings** > **Customizations** > **Developer Resources**. The URLs listed will indicate the correct domain name.  
  
    For the Marketing content pack, enter the URL as *<https://OrganizationName.marketing.dynamics.com/analytics>*, where *OrganizationName* is the organization name of your instance of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], and click **Next**  
  
4. Under **Authentication method**, select **oAuth2**.  
  
5. Your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] organization data is imported and several visualizations become available.  
  
> [!TIP]
>  If the content pack you select does not open in your web browser, in the left pane of your Power BI workspace click the content pack under **Dashboards**.  
  
### Content packs available for download.  
 The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] content packs support the default out-of-box entities. However, you can customize  the following content packs by downloading the .PBIX file and then using [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)] to customize the content pack before uploading it to the [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] service.  
  
- [Download the Dynamics CRM Online Sales Manager .PBIX](http://download.microsoft.com/download/9/2/B/92BCBDCE-CE01-4BC9-A306-2A92653B683E/Sales%20Manager.pbix)  
  
- [Download the Dynamics 365 (online) Service Manager .PBIX](http://download.microsoft.com/download/9/2/B/92BCBDCE-CE01-4BC9-A306-2A92653B683E/Customer%20Service%20Manager.pbix)  
  
  The [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] Report Template for [!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)] enables users to publish a [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] report that displays the live heart beat of connected devices.  
  
- [Download the Power BI Report Template for Connected Field Service for Dynamics 365](http://download.microsoft.com/download/E/B/5/EB5ED97A-A36A-4CAE-8C04-333A1E463B4F/PowerBI%20Report%20Template%20for%20Connected%20Field%20Service%20for%20Microsoft%20Dynamics%20365.pbix)  
  
  For information about how to customize the content packs, see [Customize Dynamics 365 Power BI content packs](../analytics/customize-power-bi-content-packs.md).  
  
<a name="BPI_embed"></a>   
## Embed [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] visualizations on personal dashboards  
 Before users can embed [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] visualizations on personal dashboards, the organization-wide setting must be enabled.  
  
> [!NOTE]
>  This feature was first introduced in [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)].  
> 
>  By default, [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] visualization embedding is disabled and must be enabled before users can embed them in personal dashboards.  
  
### Enable [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] visualizations in the organization  
  
1. Sign-in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] as a user with the system administrator security role.  
  
2. Go to **Settings** > **Administration** > **System Settings**.  
  
3. On the **Reporting** tab in the **Allow Power BI visualization embedding** option, select **Yes** to enable or **No** to disable.  
  
4. Click **OK**.  
  
To learn more about how to add [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] tiles to personal dashboards in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], see [Embed  Power BI tiles on your personal dashboard  ](../basics/add-edit-power-bi-visualizations-dashboard.md#embed--power-bi-tiles-on-your-personal-dashboard).  
  
To learn more about how to add [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] dashboards to personal dashboards in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], see [Add a Power BI dashboard on your personal dashboard](../basics/add-edit-power-bi-visualizations-dashboard.md).  
  
<a name="CRMOnline_PBIDesktop"></a>   
## Use Power BI Desktop to connect directly to your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instance  
 You can connect to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] with [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)] to create custom [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] reports and dashboards for use with the [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] service.  
  
### Requirements  
  
- [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] service registration  
  
- [Power BI Desktop](https://powerbi.microsoft.com/desktop).  
  
- [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instance  
  
### Connect to [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-subsequent.md)]  
  
1. Start [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)].  
  
2. From the Home tab, click **Get Data**, and then click **More**.  
  
3. In the Get Data list, select **Dynamics 365 Online**.  
  
4. Enter the [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-subsequent.md)] OData endpoint URL. It should look similar to this URL, where *OrganizationName* is the name of your [!INCLUDE[pn_crm_online_subsequent](../includes/pn-crm-online-subsequent.md)] organization, and **v8.1** is the version. Click **OK**.  
  
    https://<em>OrganizationName</em>.api.crm.dynamics.com/api/data/*v8.1*  
  
> [!IMPORTANT]
> Currently, the [!INCLUDE[pn_power_bi](../includes/pn-power-bi.md)] service isn’t compatible with the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] version 9.0 OData endpoint. When you try to use the version 9.0 OData endpoint with the [!INCLUDE[pn_power_bi](../includes/pn-power-bi.md)] service the error message “The feed's metadata document appears to be invalid” is displayed. To work around this incompatibility, use the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] version 8.2 OData endpoint.For more information about the different endpoint versions, see [Web API URL and versions]( https://msdn.microsoft.com/library/gg334391.aspx#bkmk_url_and_versions).
> 
> [!TIP]
>  You can find your OData endpoint URL in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web client. Go to **Settings** > **Customizations** > **Developer Resources** and locate the URL under **Instance Web API**.  
  
5. In the Access an OData feed dialog click **Organizational account**, and then click **Connect**.  
  
   > [!NOTE]
   >  If you aren't signed in to your [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instance, click **Sign-in** on the Access OData feed dialog before you click Connect.  
  
6. The organization database entity tables appear in the [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)] Navigator window. You can select both default and custom entities. For more information about creating reports with [!INCLUDE[pn_power_bi_desktop](../includes/pn-power-bi-desktop.md)], see [Power BI Support: Report View in Power BI Desktop](https://powerbi.microsoft.com/en-us/documentation/powerbi-desktop-report-view/).  
  
   ![Select entity table](../admin/media/pbi-select-entity-table.PNG "Select entity table")  
  
   > [!TIP]
   >  You can use similar steps to connect to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] using [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] Power Query by selecting **From Other Sources** on the **Power Query** tab in [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)].  
  
### See also  
