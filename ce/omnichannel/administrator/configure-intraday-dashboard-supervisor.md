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

# Configure to view intraday insights dashboard

Supervisors have a dual responsibility with respect to agents and customers. They monitor and manage agents, and make sure that they remain highly productive. At the same time, they help guarantee a superior experience for customers. To help supervisors carry out this dual responsibility, the dashboard consists of real-time monitoring and intraday health tracking of agent productivity and performance.

> [!IMPORTANT]
> The supervisor dashboards are not available in the GCC region (Gulf Cooperation Council).

As an administrator, you must configure the intraday insights dashboard in your organization before supervisors can use it. Before you configure this dashboard, you have to perform the common tasks and then tasks that are specific to **Unified Service Desk** and **Omnichannel for Customer Service** app.

Let's look at the common tasks that you have to perform to configure **Unified Service Desk** and **Omnichannel for Customer Service** app:  

1. [Review prerequisites](#review-prerequisites)
2. [Create Power BI datasets in your workspace](#create-power-bi-datasets-in-your-workspace)
3. [Verify workspace creation in Power BI](#verify-workspace-creation-in-power-bi)
4. [Configure dashboards in Power BI](#configure-dashboards-in-power-bi)


To configure the dashboard on **Unified Service Desk**, follow these steps:

1. [Perform the common tasks](#common-tasks-to-configure-intraday-insights-dashboard).
2. [Configure Unified Service Desk to display supervisor dashboard](#configure-unified-service-desk-to-display-supervisor-dashboard)
3. [Add users to supervisor configuration](#add-users-to-supervisor-configuration)
4. [Update client cache version](#update-client-cache-version)


To configure the dashboard on **Omnichannel for Customer Service** app, follow these steps:

1. [Perform the common tasks](#common-tasks-to-configure-intraday-insights-dashboard).
2. [Configure supervisor dashboard in Omnichannel for Customer Service app](#configure-supervisor-dashboard-in-omnichannel-for-customer-service-app)
3. [Share dashboard in Omnichannel for Customer Service app](#share-dashboard-in-omnichannel-for-customer-service-app)


## Common tasks to configure intraday insights dashboard 

You must perform these common tasks before you go ahead and configure intraday insights dashboard for **Unified Service Desk** and **Omnichannel for Customer Service**.

### Review prerequisites

Review the following prerequisites before configuring the supervisor dashboard: 

-  You have administrative privileges for Dynamics 365 for Customer Service and Power BI. 

-  You must have **Power BI Pro** or **Power BI Premium** license for all supervisors. 

-  You must enable to embed Power BI reports in Dynamics 365.
    1.	Sign in to **Dynamics 365 for Customer Service** and go to **Settings** > **Administration** > **System Settings**.
    2.	Go to **Reporting** tab and configure **Allow Power BI visualization embedding** as **Yes**.
    
      > [!div class=mx-imgBorder]
      > ![Enable to embed Power BI visualization](../media/supervisor-admin-enable-powerbi.png "Enable to embed Power BI visualization")
    
    3.	Select **OK**.

-  As a system administrator, you must configure the following in Power BI service:

   1. Create a security group in Azure Active Directory (AAD) and add **Omnichannel Customer Service** to that security group. To learn more, see [Manage app and resource access using Azure Active Directory groups](/azure/active-directory/fundamentals/active-directory-manage-groups). 

   2. As a Power BI admin, you need to enable service principal in the **Developer settings** in the Power BI admin portal and ddd the security group that you created in Azure AD.
        a.  Sign in to [Power BI service](http://app.powerbi.com) and go to **Settings** > **Admin portal**.
           
         > [!div class=mx-imgBorder]
         > ![Select admin portal](../media/supervisor-admin-powerbi-select-admin-portal.png "Select admin portal") 

        b.  In the Admin portal, go to **Tenant settings** > **Developer settings** > **Allow service principals to use Power BI APIs**.

        c.  Enable **Allow service principals to use Power BI APIs** and specify the security group that you want to give access.
        
         > [!div class=mx-imgBorder]
         > ![Enable service principals for security group](../media/supervisor-admin-enable-service-principals.png "Enable service principals for security group")

         > [!IMPORTANT]
         > By default, service principals inherit the permissions for all Power BI tenant settings from their security group. To restrict permissions, create a dedicated security group for service principals and add it to the **Except specific security groups** list.
        
        d. Select **Apply**. 

-  Verify that your administrator has allowed Omnichannel Customer Service to read and write data on behalf of users in your organization. To learn more, see [Provide data access consent](omnichannel-provision-license.md).  

### Create Power BI datasets in your workspace

You must configure the Power BI workspace in Dynamics 365 Customer Engagement to import the data sets that are defined for supervisor in Power BI. Follow these steps to create the supervisor datasets to your workspace.

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

4.  In the **Power BI workspace** section, select **Create New Workspace** and enter a name for the workspace in **Power BI workspace** (this name must be unique).

    > [!div class=mx-imgBorder]
    > ![Power BI workspace settings](../media/supervisor-admin-power-bi-workspace-settings.png "Power BI workspace settings")  
    
    -OR-

    If you want to add an existing Power BI workspace, select **Add existing work space** and the existing workspaces are listed. Select the workspace that you want to add.

    > [!div class=mx-imgBorder]
    > ![Add existing Power BI workspace](../media/supervisor-admin-add-existing-workspace.png "Add existing Power BI workspace")  
        
5.  Select **Configure**. The workspace creation takes a few seconds and a confirmation message is displayed with the generated workspace ID.

    > [!NOTE]
    > You can also see the status of different configuration stages such as workspace, dashboard, and data. When a workspace is created successfully, all the statuses will be in Green check. If failed, the respective configuration stage check will be in Red, and an error message is displayed. You can take necessary steps to resolve the error and create the workspace again.

    > [!div class=mx-imgBorder]
    > ![Power BI workspace ID](../media/supervisor-admin-power-bi-workspace-id.png "Power BI workspace ID")  

    In Power BI, a workspace is created.

6.  Save and close the configuration. 

    After you save the configuration, it may take up to 15 minutes for the datasets, dashboard, and reports to appear in your created workspace.

<!-- check with kiran about this-->
    > [!IMPORTANT]
    > Don't create more than one Power BI configuration in your **Omnichannel Administration** app. If you have more than one record, the application would use the configuration that you last created. If you want to add a new Power BI configuration, delete or deactivate any existing configuration.

### Verify workspace creation in Power BI

To verify the creation of workspace in Power BI, follow these steps:

1.  Sign in to **Power BI** service.

2.  Go to **Workspaces** and verify that a workspace with the name that you have entered is created.

    > [!div class=mx-imgBorder]
    > ![Select workspace](../media/supervisor-admin-power-bi-app-select-workspace.png "Select workspace")  

3.  Open the workspace that you have created and verify that the following are available:

    -   An empty dashboard with the name of the workspace.

    -   The report and datasets **IntradayMonitoring**.

### Configure dashboards in Power BI

Configuring the Power BI workspace provides you only the **IntradayMonitoring** report. Create the dashboard out of **IntradayMonitoring** Power BI report after it is available.

> [!NOTE]
> If you want reports with faster refresh rate, import the **LiveMonitoring** Power BI report. Pin tiles to the dashboard from this report for the metrics you want to view with faster refresh.  

> [!IMPORTANT]
> Share the Power BI dashboards with all Omnichannel Customer Service supervisor users. This allows supervisors to access the dashboards. To learn more, see [Share your Power BI dashboards and reports with coworkers and others](https://docs.microsoft.com/en-us/power-bi/service-share-dashboards).

Follow these steps to configure Power BI dashboards.

1.  In [Power BI Service](https://app.powerbi.com), open the reports that are available in the workspace. To learn more, see [Open a report in Power BI service](https://docs.microsoft.com/en-us/power-bi/consumer/end-user-report-open).

2.  Pin the required tiles to dashboards. To learn more, see [Pin a tile to a Power BI dashboard from a report](https://docs.microsoft.com/en-us/power-bi/service-dashboard-pin-tile-from-report).

    The following screen shows how to pin a visual to the dashboard.

   > [!div class=mx-imgBorder]
   > ![Pin a report on dashboard](../media/supervisor-admin-pin-report-to-dashboard.png "Pin a report on dashboard")  

3.  Select **Set as featured** for the created dashboard.

4.  Share the dashboard with supervisor users. To learn more, see [Share your Power BI dashboards and reports with coworkers and others](https://docs.microsoft.com/en-us/power-bi/service-share-dashboards).  

5.  For Unified Service Desk configuration, copy the URL of the dashboard.  

   The dashboard is ready, and you can configure the **Unified Service Desk** or **Omnichannel for Customer Service** to make the dashboard available for supervisors.

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


## Configuration tasks for Omnichannel for Customer Service app

After you complete the common tasks, you must perform the tasks defined in this section to complete the configuration for Intraday insights dashboard for **Omnichannel for Customer Service**.

### Configure supervisor dashboard in Omnichannel for Customer Service app

To view the supervisor dashboards in **Omnichannel for Customer Service**, you must add the Power BI reports to your app.

1.  Sign in to Dynamics 365 for Customer Service app.

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

    The supervisor dashboard is added to **Omnichannel for Customer Service**.

### Share dashboard in Omnichannel for Customer Service app

You must share the Intraday insights dashboard with supervisors in your organization to access the dashboard in **Omnichannel for Customer Service**. To share the dashboard, follow these steps:

1.  Sign in to **Dynamics 365 for Customer Service** and open **Omnichannel for Customer Service**.

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


## Provide access to Ongoing Conversations dashboard

To access the **Omnichannel Ongoing Conversations** dashboard, you must assign **Omnichannel supervisor** role to the users. To learn more, see [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md).  

Once the users get access to **Omnichannel Ongoing Conversations** dashboard is available on **Unified Service Desk** and **Omnichannel for Customer Service** app. To learn more, see [Omnichannel Ongoing Conversations dashboard](../supervisor/ongoing-conversations-dashboard.md).

### See also

[Introduction to Intraday insights dashboard](../supervisor/intro-intraday-insights-dashboard.md)
