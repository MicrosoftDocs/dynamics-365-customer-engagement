---
title: "Configure to view Intraday insights dashboard | MicrosoftDocs"
description: "Instructions to configure intraday insights dashboard for Unified Service Desk and Omnichannel for Customer Service."
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 6/20/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 184b39be-7ac3-45f1-a63e-d6ad2cb7b547
ms.custom: 
---

# Configure intraday insights dashboard

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Supervisors have a dual responsibility with respect to agents and customers. They monitor and manage agents, and make sure that they remain highly productive. At the same time, they help guarantee a superior experience for customers. To help supervisors carry out this dual responsibility, the dashboard consists of real-time monitoring and intraday health tracking of agent productivity and performance.

> [!IMPORTANT]
> The supervisor dashboards that are based on Power BI such as Intraday insights dashboard is not available on Government Community Cloud (GCC). 

As an administrator, you must configure the intraday insights dashboard in your organization before supervisors can use it. Before you configure this dashboard, you have to perform the common tasks and then tasks that are specific to **Unified Service Desk** and **Omnichannel for Customer Service** app on web.

Let's look at the common tasks that you have to perform to configure **Unified Service Desk** and **Omnichannel for Customer Service** app on web:  

1. [Review prerequisites](#review-prerequisites)
2. [Configure Power BI workspace](#configure-power-bi-workspace)
3. [Verify workspace creation in Power BI](#verify-workspace-creation-in-power-bi)
4. [Configure dashboards in Power BI](#configure-dashboards-in-power-bi)


To configure the dashboard on **Unified Service Desk**, follow these steps:

1. [Perform the common tasks](#common-tasks-to-configure-intraday-insights-dashboard).
2. [Configure Unified Service Desk to display supervisor dashboard](#configure-unified-service-desk-to-display-supervisor-dashboard)
3. [Add users to supervisor configuration](#add-users-to-supervisor-configuration)
4. [Update client cache version](#update-client-cache-version)


To configure the dashboard on **Omnichannel for Customer Service** app on web, follow these steps:

1. [Perform the common tasks](#common-tasks-to-configure-intraday-insights-dashboard).
2. [Configure supervisor dashboard in Omnichannel for Customer Service app on web](#configure-supervisor-dashboard-in-omnichannel-for-customer-service-app-on-web)
3. [Share dashboard in Omnichannel for Customer Service app on web](#share-dashboard-in-omnichannel-for-customer-service-app-on-web)


## Common tasks to configure intraday insights dashboard 

You must perform these common tasks before you go ahead and configure intraday insights dashboard for **Unified Service Desk** and **Omnichannel for Customer Service** app on web.

### Review prerequisites

Review the following prerequisites before configuring the supervisor dashboard: 

-  You have administrative privileges for Dynamics 365 for Customer Service and Power BI. 

-  You must have **Power BI Pro** or **Power BI Premium** license for all supervisors and administrators. 

-  You must enable to embed Power BI reports in Dynamics 365 for **Omnichannel for Customer Service** app on web.
    1.	Sign in to **Dynamics 365 for Customer Service** and go to **Settings** > **Administration** > **System Settings**.
    2.	Go to **Reporting** tab and configure **Allow Power BI visualization embedding** as **Yes**.
    
      > [!div class=mx-imgBorder]
      > ![Enable to embed Power BI visualization](../media/supervisor-admin-enable-powerbi.png "Enable to embed Power BI visualization")
    
    3.	Select **OK**.

-  As a system administrator, you must configure the following in Power BI service:

   1. Create a security group in Azure Active Directory (AAD) and add **Omnichannel for Customer Service** as a member to that security group. To learn more, see [Create a basic group and add members using Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-groups-create-azure-portal). 

   2. As a Power BI admin, you need to enable service principal in the **Developer settings** in the Power BI admin portal and the security group that you created in Azure AD.
        a.  Sign in to [Power BI service](http://app.powerbi.com) and go to **Settings** > **Admin portal**.
           
         > [!div class=mx-imgBorder]
         > ![Select admin portal](../media/supervisor-admin-powerbi-select-admin-portal.png "Select admin portal") 

        b.  In the Admin portal, go to **Tenant settings** > **Developer settings** > **Allow service principals to use Power BI APIs**.

        c.  Enable **Allow service principals to use Power BI APIs** and specify the security group that you want to give access.
        
         > [!div class=mx-imgBorder]
         > ![Enable service principals for security group](../media/supervisor-admin-enable-service-principals.png "Enable service principals for security group")

        d. Select **Apply**. 

-  Verify that your administrator has allowed **Omnichannel for Customer Service** app to read and write data on behalf of users in your organization. To learn more, see [Provide data access consent](omnichannel-provision-license.md).  

### Configure Power BI workspace

You must configure the Power BI workspace using the **Omnichannel Administration** app to import the datasets and reports for Power BI. Follow these steps to create the supervisor datasets to your workspace.

1.  Sign in to **Dynamics 365 for Customer Service** and open **Omnichannel Administration** app. 

    > [!div class=mx-imgBorder]
    > ![Select Omnichannel administration](../media/supervisor-admin-select-omnichannel-administration.png "Select Omnichannel administration")

2.  From the **Site Map** ![Site map icon](../media/oc-usd-supervisor-dashboard-site-map.png "Site map icon"), select **Supervisor Experience**, **Overview Dashboard**.  

    > [!div class=mx-imgBorder]
    > ![Select overview dashboard option](../media/supervisor-admin-select-overview-dashboard.png "Select overview dashboard option")

    The Power BI configuration view opens.

    > [!div class=mx-imgBorder]
    > ![Configuration of Power BI workspace](../media/supervisor-admin-active-powerbi-configuration.png "Configuration of Power BI workspace")

3.  Select **+ New**. 

    The **Power BI Configuration** form opens.

    > [!div class=mx-imgBorder]
    > ![Power BI workspace configuration settings page](../media/supervisor-admin-powerbi-configuration-settings.png "Power BI workspace configuration settings page")

4. Select **Enable Intraday Insights for multi session web** option as **Yes** to make Intraday insights dashboard available on Omnichannel for Customer Service app on web.

    > [!div class=mx-imgBorder]
    > ![Enable to display Intraday insights dashboard on Omnichannel for Customer Service app](../media/supervisor-admin-intraday-insights-dashboard-oc-on-web.png "Enable to display Intraday insights dashboard on Omnichannel for Customer Service app")
  
5.  In the **Power BI workspace** section, select **Create New Workspace** and enter a name for the workspace in **Power BI workspace** (this name must be unique).

    > [!div class=mx-imgBorder]
    > ![Power BI workspace settings](../media/supervisor-admin-power-bi-workspace-settings.png "Power BI workspace settings")  
    
    -OR-

    If you want to add an existing Power BI workspace, select **Add existing work space** and the existing workspaces are listed. Select the workspace that you want to add.

    > [!div class=mx-imgBorder]
    > ![Add existing Power BI workspace](../media/supervisor-admin-add-existing-workspace.png "Add existing Power BI workspace")  
        
6.  Select **Configure**. The workspace creation takes a few seconds and a confirmation message is displayed with the generated workspace ID.

    > [!div class=mx-imgBorder]
    > ![Power BI workspace ID](../media/supervisor-admin-power-bi-workspace-id.png "Power BI workspace ID")  

    In Power BI, a workspace is created.

7.  Save and close the configuration. 

    After you save the configuration, it may take up to 15 minutes for the datasets, dashboard, and reports to appear in your created workspace.

    > [!NOTE]
    > You can also see the status of different configuration stages such as workspace, dashboard, and datasets. When a workspace is created successfully, all the statuses will be in Green check. If failed, the respective configuration stage check will be in Red, and an error message is displayed. Resolve the error and create the workspace again.

   > [!IMPORTANT]
   > - You can configure only one record in **Omnichannel Administration** app. 
   > - If you want to create a new configuration, deactivate and delete the existing configuration.
   > - You can edit an existing configuration to update the Power BI workspace details.

### Verify workspace creation in Power BI

To verify the creation of workspace in Power BI, follow these steps:

1.  Sign in to **Power BI** service.

2.  Go to **Workspaces** and verify that a workspace with the name that you have entered is created.

    > [!div class=mx-imgBorder]
    > ![Select workspace](../media/supervisor-admin-power-bi-app-select-workspace.png "Select workspace")  

3.  Open the workspace that you have created and verify that the following are available:

    -   An empty dashboard with the name of the workspace.

    -   The report and datasets **Intraday Monitoring**.

### Configure dashboards in Power BI

Configuring the Power BI workspace provides you only the **Intraday Monitoring** report. Create the dashboard out of **Intraday Monitoring** Power BI report after it is available.

> [!IMPORTANT]
> In Power BI settings for **Intraday Monitoring**, DO NOT select the option **Take over**. If you select this option, the dataset will not connect to the datasource and you have to reconfigure intraday insights dashboards. 

> [!NOTE]
> If you want the dashboards with faster refresh rate, import the **Live Conversations** Power BI report. Pin tiles to the dashboard from this report for the metrics you want to view with faster refresh. This dashboard consists of Active and open conversations, Conversations exceeding 5 min wait time, Conversations exceeding 5 min handle time, Total conversations transferred, and Open conversations.


Follow these steps to configure Power BI dashboards.

1.  In [Power BI Service](https://app.powerbi.com), open the reports that are available in the workspace. To learn more, see [Open a report in Power BI service](https://docs.microsoft.com/en-us/power-bi/consumer/end-user-report-open).

2.  Pin the required tiles to dashboards. 
    The following screen shows how to pin a visual to the dashboard.

   > [!div class=mx-imgBorder]
   > ![select report](../media/supervisor-admin-pin-report-to-dashboard.png "select report")  

  Choose on which dashboard you want to pin and select **Pin**. The report is pinned to the chosen dashboard.

   > [!div class=mx-imgBorder]
   > ![Pin a report on dashboard](../media/supervisor-admin-pin-report-dashboard.png "Pin a report on dashboard")  

  To learn more, see [Pin a tile to a Power BI dashboard from a report](https://docs.microsoft.com/en-us/power-bi/service-dashboard-pin-tile-from-report).

3.  Select **Set as featured** for the created dashboard to display on the top for each time you open the Power BI service.

4.  Share the dashboard with supervisor users. This allows supervisors to access the dashboards. To learn more, see [Share your Power BI dashboards and reports with coworkers and others](https://docs.microsoft.com/en-us/power-bi/service-share-dashboards).  

5.  For Unified Service Desk configuration, copy the URL of the dashboard.  

   The dashboard is ready, and you can configure the **Unified Service Desk** or **Omnichannel for Customer Service** on web to make the dashboard available for supervisors.

## Configuration tasks for Unified Service Desk 

After you complete the common tasks, you must perform the tasks defined in this section to complete the configuration for Intraday insights dashboard for **Unified Service Desk**.

### Configure Unified Service Desk to display supervisor dashboard

You must configure the **Unified Service Desk** to display the supervisor intraday insights dashboard when a supervisor signs in to the workspace in Omnichannel. To configure the **Unified Service Desk**, follow these steps:

1.  Sign in to **Dynamics 365 for Customer Service** and go to **Settings** > **Unified Service Desk**.

    The Unified Service Desk settings page opens.

2.  Select **Action Calls** and open **Load Supervisor Dashboard**.

3.  In the **Action** section, enter the **Data** as “*url=* *https://powerbi.com/dashboards/&lt;id&gt;*” that you copied in [Configure dashboards in Power BI](#configure-dashboards-in-power-bi). Also, add the parameters **chromeless=1** and **nosignupcheck=1** at the end of the URL.  

    For example,

    url=*https://powerbi.com/dashboards/g12466b5-a452-4e55-8634-xxxxxxxxxxxx?chromeless=1&nosignupcheck=1*

4.  Save and close the settings page.

The supervisor dashboard is configured and available. Add users to supervisor configuration to view the dashboards when signing on to the Omnichannel in **Unified Service Desk**. 

### Add users to supervisor configuration

You must add users in the supervisor configuration to access any supervisor dashboard in **Unified Service Desk**. To add users in supervisor configuration, follow these steps:

1.  Sign in to Dynamics 365 for Customer Service.

2.  Go to **Settings** > **Unified Service Desk** and then select **Configuration**.

3.  On the configuration page, select **Supervisor Configuration**.

    > [!div class=mx-imgBorder]
    > ![Select supervisor configuration](../media/supervisor-admin-select-supervisor-configuration-add-user.png "Select supervisor configuration")  

4.  On the **Users** section, select **+ Add User record** and enter the user name to add the user.

    > [!div class=mx-imgBorder]
    > ![Add user to supervisor configuration](../media/supervisor-admin-supervisor-configuration-add-user.png "Add user to supervisor configuration")  

5.  Save and close the configuration.

    Users are added to the supervisor dashboard and when they sign in to Omnichannel on Unified Service Desk, the supervisor dashboard tabs are available.

### Update client cache version

Update the client cache version number to reduce the amount of bandwidth required at the startup of the Unified Service Desk client on the computers of agents, and over the life cycle of the client application.

To learn more, see [Client caching overview](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/unified-service-desk/admin/configure-client-caching-unified-service-desk?view=dynamics-usd-4.1).  

1.  Sign in to **Dynamics 365 for Customer Service**.

2.  Go to **Settings** > **Unified Service Desk** and then select **Options**.

    > [!div class=mx-imgBorder]
    > ![Select options in settings](../media/supervisor-admin-select-options-usd-settings.png "Select options in settings")  
 
3.  Select **ClientCacheVersionNumber**.

    > [!div class=mx-imgBorder]
    > ![Select client cache version number](../media/supervisor-admin-select-client-cache-version-number.png "Select client cache version number")  

4.  In the **Value** box, updated the existing alphanumeric number. For example, the existing alphanumeric number is OC2019\_04\_010 and updated this number as OC2019\_04\_011.

    > [!div class=mx-imgBorder]
    > ![Update value](../media/supervisor-admin-update-value-client-cache-number.png "Update value")  

5.  Select **Save**.


## Configuration tasks for Omnichannel for Customer Service app on web

After you complete the common tasks, you must perform the tasks defined in this section to complete the configuration for Intraday insights dashboard for **Omnichannel for Customer Service** on web.

### Configure supervisor dashboard in Omnichannel for Customer Service app on web

To view the supervisor dashboards in **Omnichannel for Customer Service** on web, you must add the Power BI dashboard to your app.

1.  Sign in to **Omnichannel for Customer Service** app.

2.  On the site map, select add icon (**+**) and then select **Dashboards**.

    > [!div class=mx-imgBorder]
    > ![Select dashboard to add](../media/supervisor-admin-select-dashboard.png "Select dashboard to add")  

3.  On the dashboard page, select **New** > **Power BI Dashboard**.

    > [!div class=mx-imgBorder]
    > ![Select Power BI dashboard option](../media/supervisor-admin-select-power-bi-dashboard-option.png "Select Power BI dashboard option")  

4.  On the **Power BI Dashboard Properties** dialog, select **Workspace** in which you have the dashboards and then select **Dashboard**.

    > [!div class=mx-imgBorder]
    > ![Select the Power BI dashboard](../media/supervisor-admin-select-dashboard-to-add.png "Select the Power BI dashboard")  

5.  Select **Save**.

    The supervisor dashboard is added to **Omnichannel for Customer Service** on web.

To learn more, see [Add or edit Power BI visualizations on your dashboard](/dynamics365/customer-engagement/basics/add-edit-power-bi-visualizations-dashboard)

### Share dashboard in Omnichannel for Customer Service app on web

You must share the Intraday insights dashboard with supervisors in your organization to access the dashboard in **Omnichannel for Customer Service**. To share the dashboard, follow these steps:

1.  Sign in to **Omnichannel for Customer Service** app.

2.  From the dashboard view selector, under **My Dashboards**, select the intraday insights dashboard that you want to share with supervisors. In this example, we are selecting **Contoso**.

   > [!div class=mx-imgBorder]
   > ![Select dashboard to share](../media/supervisor-admin-select-dashboard-to-share.png "Select dashboard to share")  

3.  Select **Share Dashboard**.

   > [!div class=mx-imgBorder]
   > ![Select share dashboard option](../media/supervisor-admin-select-share-dashboard-option.png "Select share dashboard option")  

4.  On the **Share user dashboard** dialog, select **Add User/Team**.

   > [!div class=mx-imgBorder]
   > ![Select add user or team option](../media/supervisor-admin-share-user-dashboard.png "Select add user or team option")  

5.  On the **Look Up Records** dialog, search for the team or users you want to add and select **Select**.

   > [!div class=mx-imgBorder]
   > ![Select users or teams](../media/supervisor-admin-search-select-users-team.png "Select users or teams")  

6.  Select **Add**. 

    The users/teams are added to the share list

7. Select the users and privileges that you want to grant. Select **Share**.

   > [!div class=mx-imgBorder]
   > ![Select users and teams and share the dashboard](../media/supervisor-admin-add-privileges-and-share.png "Select users and teams and share the dashboard")  

    The Intraday insights dashboard is shared with the users or teams that you have selected.


### See also

[Introduction to Intraday insights dashboard](../supervisor/intro-intraday-insights-dashboard.md)
