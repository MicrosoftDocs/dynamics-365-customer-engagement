---
title: Model customization of historical and real-time analytics reports in Customer Service
description: Learn how to customize historical and real-time analytics reports in Dynamics 365 Customer Service using Power BI.
ms.date: 11/04/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
---

# Customize data models of historical and real-time analytics reports

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

Use the extensibility feature in Microsoft Power BI to extend the out-of-the-box data models for the analytics reports in Customer Service and integrate with other semantic models to create new custom metrics. You can customize the out-of-the-box standard reports and add your own Key Performance Indicators (KPIs) to view the key metrics that are relevant to your organization. You can also add custom metrics to the detail reports.

The key capabilities of model customization include the ability to:

- Edit the out-of-the-box data model and add new metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Microsoft Fabric workspace.

- Customize the report site map and enable users to access the reports natively from the Customer Service workspace app.

- Auto refresh reports as soon as source data is updated.

Enable data model customization for historical and real-time analytics reports in Customer Service admin center, and then complete the following tasks:

1. Select a Microsoft Fabric workspace.
1. Provision the data models and copy of reports.
1. Grant permissions for semantic models and reports.
1. Embed customized reports back to Dynamics 365.

## Prerequisites

Before you begin, you must complete the following prerequisites:

- Your organization must have the Microsoft Fabric Capacity for all report users to access the reports. Learn more in [Microsoft Fabric](/fabric/get-started/microsoft-fabric-overview).
- Your organization must have the Power BI Premium per user license for report authors, developers, and administrators to build Power BI reports and extend the out-of-the-box Power BI data model.

- Enable insights features in Customer Service:

  - If you're enabling historical data model customization, you must enable at least one of the historical reports, such as Customer Service historical analytics, Omnichannel historical analytics, or knowledge analytics. For more information, see [Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md).
  - If you're enabling real-time data model customization, you must enable real-time analytics for Omnichannel. For more information, see [Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md).

- Create a Microsoft Entra ID security group:

  - Your Microsoft Entra ID administrator must create a security group with your preferred name in Microsoft Entra ID and add **Dynamics 365 Analytics** service account as a member of this security group. For more information, see [Create a basic group and add members using Microsoft Entra ID](/entra/fundamentals/how-to-manage-groups).

      The out-of-the-box **Service Principal Dynamics 365 Analytics** is used to deploy the data model and make changes to the Microsoft Fabric workspace on behalf of Customer Service.

      Permissions within Power BI can be granted to groups only and not individual service principals, and therefore a group needs to be created.

  > [!NOTE]
  > In organizations where the Dynamics 365 Analytics service account might not be available, you need to use the Dynamics CCA Data Analytics service account.

- Enable Power BI service features from the Microsoft Fabric Admin portal. The Power BI administrator must enable the following, either for the entire organization or for the security group created earlier:

  - [**Create workspace (new workspace experience)**](/power-bi/admin/service-admin-portal-workspace#create-workspaces-new-workspace-experience): Enabling this feature creates two workspaces, a managed workspace and a customer workspace to deploy Dynamics data model and reports.

  - [**Service principals can use Fabric APIs**](/power-bi/enterprise/service-premium-service-principal#enable-service-principals): This feature uses the Fabric APIs for creating workspaces, deploying reports and models.

  - **Allow DirectQuery connections to Power BI semantic models**: When report authors build new metrics or bring more data sources, they create [composite models](/power-bi/transform-model/desktop-composite-models#managing-composite-models-on-power-bi-datasets), so DirectQuery needs to be enabled. Users who view reports built on top of data model in Dynamics 365 require this permission. Work with your Microsoft Entra ID administrator to identify a security group that has all the required Dynamics users.
  
  - **Allow XMLA endpoints and Analyze in Excel with on-premise semantic models**: When report authors build new metrics or bring more data sources, they create [composite models](/power-bi/transform-model/desktop-composite-models#managing-composite-models-on-power-bi-datasets), so this feature needs to be enabled. Users who view reports built on top of data model in Dynamics 365 require this permission.

  - **Embed content in apps**: Enabling this feature embeds customized reports in Dynamics 365 ([Step 4: Embed customized reports back to Dynamics 365](#step-4-embed-customized-reports-back-to-dynamics-365)). Users who view the custom reports from Dynamics 365 Customer Service require this permission. Work with your Microsoft Entra ID administrator to identify a security group that has all the required Dynamics users.

## Enable Power BI data model customization

 1. In the Customer Service admin center site map, select **Insights** in **Operations**.
 1. On the **Insights** page in the **Report settings** section:
     - For historical, select **Embedded Power BI extensibility - Historical data model customization** and then select **Manage**.
     - For real time, select **Embedded Power BI extensibility - Real-time data model customization** and then select **Manage**.
 1. On the selected page, switch the **Enable embedded Power BI data model customization** toggle to **On**.

## Step 1: Select a Microsoft Fabric workspace

  > [!NOTE]
  > If you plan to use an existing Microsoft Fabric workspace to host the copy of the out-of-the-box reports (customer workspace), make sure that the Dynamics Administrator (user sign in) enabling the model customization is a workspace administrator of that Microsoft Fabric workspace.

Specify the Microsoft Fabric workspace where the Dynamics data model and reports are provisioned.

1. From the Insights page, go to the data model for which you want to select a Microsoft Fabric workspace.

1. Select **Create new workspace** or to use an existing workspace, select a workspace from the dropdown list.

1. Select **Save**. This action initiates the provisioning of the reports.

The specified workspace applies only to the customer's workspace. Microsoft creates a new managed workspace for historical and real-time reports each, when configured. For more information, see [How data model customization works](../use/datamodel-overview.md#how-data-model-customization-works). You can also specify the same workspace for both historical and real-time analytics reports.

## Step 2: Provision the data models

It could take up to 24 hours for the provisioning to complete. You can leave the **Settings** page and check back after a few hours. Select **Refresh** to check the provisioning status.

## Step 3: Grant permissions for semantic models and reports

After the report is provisioned, you must provide **Write** permissions for users who author reports in Power BI and **Read** permissions for supervisors and other consumers of the reports.

You must be a **Workspace Administrator** on both managed and customer workspaces (configured on Step 1) in Power BI to complete this step. By default, the user who starts the provisioning (Step 2) has the necessary permissions added.

:::image type="content" source="../media/step3-grant-permissions.png" alt-text="Screenshot of step 3 grant, read and write permissions":::

### Grant access to the Power BI data model

Report authors connect to the specified data model to build custom reports. When you select the **Power BI Data model** link, the managed workspace opens up and the details of the data model are displayed. Use the **Share** dialog to provide access to users by entering their email address. For more information, see [Share access to a semantic model](/power-bi/connect-data/service-datasets-share).

You need to provide report authors and viewers with **Allow recipients to build content with the data associated with this semantic model** access.

### Grant permissions to the customized Power BI report (optional)

When you select the **Customized Power BI Report** link, the Microsoft Fabric workspace where the sample reports are provided appears in a lineage view. These reports are the copy of your out-of-the-box reports and can be edited and modified. You must provide access to the workspace only if your organization plans on using these copies to develop reports.

Select **Access**, and provide **Contributor** access to your report authors and **Viewer** access to users who view these or any other reports built in this Microsoft Fabric workspace. If you plan to embed the report back to Dynamics 365 Customer Service, you must provide **Member** access to the supervisors for them to view the embedded report within the Customer Service workspace. For more information on data permissions, see [Manage semantic model access permissions (preview)](/power-bi/connect-data/service-datasets-manage-access-permissions).

## Step 4: Embed customized reports back to Dynamics 365

After your report authors create and publish the customized reports, you can allow Dynamics users to access these reports from the Customer service workspace. This step is optional.

1. Select the data model reports.


### [Historical data model customization](#tab/historicaldatamodelcustomization)

  - From the **Embedded Power BI extensibility - Historical data model customization** page, go to Step 4.
    :::image type="content" source="../media/embed-historical.png" alt-text="Screenshot of the historical reports you want to view on the site map.":::

### [Real-time data model customization](#tab/realtimedatamodelcustomization)

  - From the **Embedded Power BI extensibility - Real-time data model customization** page, go to Step 4.
    :::image type="content" source="../media/embed-realtime.png" alt-text="Screenshot of the real-time reports you want to view on the site map.":::

---
2. Select **Add report**. The **Add report** dialog appears.
3. Enter a preferred name in the **Report name** text box.
4. From the **Select Power BI report** dropdown list, select the Power BI report in the workspace.
5. Select **Add** and **Save**.


The dropdown list is populated with the reports in the workspace configured on Step 1. The preferred report name appears for your Dynamics users when they access the reports. You can add a maximum of 40 reports.

The customized reports site map in the Customer service workspace is shared between historical and real-time data model customization features. You can reorder the reports on both historical and real time admin pages. For both historical and real time, you can modify or delete reports added from the respective historical and real-time data model customization pages only.

You can also perform supervisor actions like [assign, transfer, monitor, and force close](../use/realtime-ongoing.md#assign-transfer-monitor-or-force-close-conversations-in-customized-reports) on model customized reports.

## Enable automatic page refresh for reports

Automatic page refresh is available only for real-time reports.

You can enable automatic page refresh for your reports at fixed intervals so that you always see the latest data. For more information, see [Authoring reports with automatic page refresh in Power BI Desktop](/power-bi/create-reports/desktop-automatic-page-refresh#authoring-reports-with-automatic-page-refresh-in-power-bi-desktop).

As an administrator with Premium capacity, you must first enable [automatic page refresh](/power-bi/enterprise/service-admin-premium-workloads#automatic-page-refresh) from the [Microsoft Fabric Admin portal](https://msit.powerbi.com/). You need to use the [fixed interval](/power-bi/create-reports/desktop-automatic-page-refresh#fixed-interval) refresh type with either 5 or 10 seconds as the interval.

To enable automatic page refresh for specific reports:

1. Download the real-time report from your Customer Service workspace app.
1. Go to **Visualizations** > **Format page**.
1. Switch the **Page refresh** toggle to **On**.
1. Select **Auto page refresh** from the **Refresh type** dropdown list.
1. Set the refresh period to either 5 or 10 seconds.
1. Select **Publish** to publish the updated report to the customized workspace.

In case you change the report name, perform the steps provided in [Step 4: Embed customized reports back to Dynamics 365](#step-4-embed-customized-reports-back-to-dynamics-365).

## View customized reports

If you customized the Customer Service workspace app, you must complete the following steps to view the reports.

1. On the Customer Service workspace app tile, select the ellipsis for **More Options** and then select **Open in App Designer**.
1. Select **New**.
1. On the **New page** dialog, select **URL**, and then select **Next**.
1. Enter the following information and then select **Add**.
      - **URL**: [Organization Url]/main.aspx?pagetype=control&controlName=MscrmControls.Analytics.ModernReportingControl&data={"featureIds":"f2266eb4-226f-4cf1-b422-89c5f48b40cb,09c168be-efe2-4f08-a986-3aab7095c863"}
      - **Title**: Customized Reports
1. From **Navigation**, select **Customized Reports**.
1. Enter the following information for **Display options**.
    - **Title**: Customized Reports
    - **Icon**: Select **Use web resource**.
    - **Select icon**: msdyn_/Analytics/imgs/CustomizedReportsIcon.svg
    - **ID**: CustomizedReportsSubArea
1. Select **Advanced Settings** and then select the following checkboxes:
   - **SKU**: **All**, **On premise**, **Live**, and **SPLA**
   - **Client**: **Web**
   - **Outlook shortcut**: **Pass parameters** and **Offline availability**
1. Select **Save** and then select **Publish**.

### Related information

[Customize the display of analytics reports](../use/customize-reports.md#customize-the-display-of-analytics-reports)  
[Introduction to Customer Service Insights](../implement/introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics dashboards in Power BI](../implement/configure-customer-service-analytics-dashboard.md)  
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
