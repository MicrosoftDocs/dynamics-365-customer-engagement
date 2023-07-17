---
title: "Model customization of historical and real-time analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical and real-time analytics reports in Dynamics 365 Customer Service using Power BI."
ms.date: 06/12/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
---

# Customize data models of historical and real-time analytics reports

Use the extensibility feature in Microsoft Power BI to extend the out-of-the-box Dynamics 365 Customer Service Power BI data model and integrate with other datasets to create new custom metrics. You can customize the out-of-the-box standard reports and add your own KPIs and custom metrics to the reports to view the key metrics that are relevant to your organization. You can also drill down to add your metrics to the report as required.

The key capabilities of model customization include the ability to:

- Edit the out-of-the-box data model and add new metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from Customer Service workspace.

You can enable data model customization for historical and real-time analytics reports from the Customer Service admin center. After you enable, you'll need to perform the following tasks.

1. Select a Power BI workspace
1. Provision the data models and copy of reports
1. Grant permissions for dataset and reports
1. Embed customized reports back to Dynamics 365
    
## Prerequisites

Before you begin, you must complete the following prerequisites:

- Your organization must have the Power BI Professional or Power BI Premium license for all supervisors and administrators.

- Enable insights features in Dynamics 365 Customer Service:
    - If you are enabling historical data model customization, you must enable at least one of the historical reports, such as customer service historical analytics, Omnichannel historical analytics, or knowledge analytics. More information: [Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md)
    - If you are enabling real-time data model customization, you must enable real-time analytics for Omnichannel. More information: [Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md)

- Enable Power BI service features from the Power BI admin portal. The Power BI administrator must enable the following:  

     - **Create workspace (new workspace experience)**: Enabling this creates two workspaces, a managed workspace and a customer workspace to deploy Dynamics data model and reports. More information: [Create workspaces (new workspace experience)](/power-bi/admin/service-admin-portal-workspace#create-workspaces-new-workspace-experience)

    - **Allow service principals to use Power BI APIs**: This uses the Power BI APIs for creating workspaces, deploying reports and models. More information: [Enable service principals](/power-bi/enterprise/service-premium-service-principal#enable-service-principals)  

    - **Allow DirectQuery connections to Power BI datasets**: When report authors build new metrics or bring additional data sources, they will create composite models which requires DirectQuery enabled. More information: [Managing composite models on Power BI datasets](/power-bi/transform-model/desktop-composite-models#managing-composite-models-on-power-bi-datasets)

- Provide **Dynamics 365 service principal** access to Power BI.

     - Your Microsoft Entra ID administrators must create a security group in Microsoft Entra ID with a preferred name of your choice. Add **Dynamics 365 Analytics** as a member of this security group. More information: [Create a basic group and add members using Azure Active Directory](/azure/active-directory/fundamentals/active-directory-groups-create-azure-portal)

        The out-of-the-box **Service Principal Dynamics 365 Analytics** is leveraged to deploy the data model and make changes to the Power BI workspace on behalf of Dynamics 365 Customer Service. Permissions within Power BI can be granted only to groups and not individual service principals, and therefore a group needs to be created.
        
    > [!NOTE]
    > In organizations where Dynamics 365 Analytics may not be available, you need to use Dynamics CCA Data Analytics.

    - Power BI administrators must add the security group created in Microsoft Entra ID to Power BI service settings.

        - **Service Principal** in the **Developer settings**.
        - Create **workspaces** in the **Tenant settings**.
        
    - If you plan to use an existing Power BI workspace to host the copy of the out-of-the-box reports (customer workspace), make sure that the Dynamics Administrator (user login) enabling the model customization is a workspace administrator of that Power BI workspace.

## Enable Power BI data model customization

 1. In the Customer Service admin center site map, select **Insights** in **Operations**.
 1. On the **Insights** page in the **Report settings** section:
     1. For historical, select **Embedded Power BI extensibility - Historical data model customization** and then select **Manage**.
     1. For real time, select **Embedded Power BI extensibility - Real-time data model customization** and then select **Manage**.
 1. On the selected page, switch the **Enable embedded Power BI data model customization** toggle to **On**.
 
## Step 1: Select a Power BI workspace

Specify the Power BI workspace where the Dynamics data model and reports will be provisioned.

1. Go to the data model for which you want to select a Power BI workspace.

### [Historical data model](#tab/historicaldatamodel)

  - On the **Embedded Power BI extensibility - Historical data model customization** page:
      - To use an existing workspace, select the workspace from the dropdown list.
      - To create a new workspace, select **Create new workspace**.
  
      :::image type="content" source="media/workspace-historical.png" alt-text="Select a workspace to configure historical data model customization":::

### [Real-time data model](#tab/realtimedatamodel)

  - On the **Embedded Power BI extensibility - Real-time data model customization** page:
      - To use an existing workspace, select the workspace from the dropdown list.
      - To create a new workspace, select **Create new workspace**.
  
      :::image type="content" source="media/workspace-realtime.png" alt-text="Select a workspace to configure real-time data model customization":::  

---

2. Select **Save**. This initiates the provisioning of the reports.
 
> [!NOTE]
> The specified workspace applies only to the customer's workspace. A new managed workspace will be created by Microsoft for historical and real-time reports each, when configured. For more information, go to: [How data model customization works](datamodel-overview.md#how-data-model-customization-works). You can also specify the same workspace for both historical and real-time analytics reports.

## Step 2: Provision the data models

It could take up to 24 hours for the provisioning to complete. You can leave the **Settings** page and check back after a few hours. Select **Refresh** to check the provisioning status.

## Step 3: Grant permissions for dataset and reports

After the report is provisioned, you must provide **Write** permissions for users who will be authoring reports in Power BI and **Read** permissions for supervisors and other consumers of the reports.

You'll need to be a **Workspace Administrator** on both managed and customer workspaces (configured on Step 1) in Power BI to complete this step. By default, the user who starts the provisioning (Step 2) will have the necessary permissions added.

### Grant access to the Power BI data model

Report authors will connect to the specified data model to build custom reports. When you select the **Power BI Data model** link, the managed workspace opens up and the details of the data model are displayed. Use the **Share** dialog to provide access to users by entering their email address. More information: [Share access to a dataset](/power-bi/connect-data/service-datasets-share).

You need to:

- Provide report authors with **Allow recipients to build content with the data associated with this dataset** access.

- For report viewers like supervisors, you may choose to share the dataset without providing any additional permissions.

### Grant permissions to the customized Power BI report (optional)

When you select the **Customized Power BI Report** link, the Power BI workspace where the sample reports will be provided appears in a lineage view. These reports are the copy of your out-of-the-box reports and can be edited and modified. You'll have to provide access to the workspace only if your organization plans on using these copies to develop reports.

From the lineage view, select **Access**, and provide **Contributor** access to your report authors and **Viewer** access to users who will be viewing these or any other reports built in this workspace. For more information on data permissions, go to: [Manage dataset access permissions (preview)](/power-bi/connect-data/service-datasets-manage-access-permissions). You'll have to provide these permissions only if you plan to use these reports.  

## Step 4: Embed customized reports back to Dynamics 365

After your report authors have created and published the customized reports, you can allow Dynamics users to access these reports from the Customer service workspace.

1. Select the data model reports.

### [Historical data model customization](#tab/historicaldatamodelcustomization)

  - From the **Embedded Power BI extensibility - Historical data model customization** page, go to Step 4.
    :::image type="content" source="media/embed-historical.png" alt-text="Select the historical reports you want to view on the site map.":::

### [Real-time data model customization](#tab/realtimedatamodelcustomization)

  - From the **Embedded Power BI extensibility - Real-time data model customization** page, go to Step 4.
    :::image type="content" source="media/embed-realtime.png" alt-text="Select the real-time reports you want to view on the site map.":::

---

2. Select **Add report**. The **Add report** dialog appears.
3. Enter a preferred name in the **Report name** text box.
4. From the **Select Power BI report** dropdown list, select the Power BI report in the workspace.
5. Select **Add** and **Save**.

The dropdown list is populated with the reports in the workspace configured on Step 1. The preferred report name will appear for your Dynamics users when they access the reports. You can add a maximum of 40 reports.

The customized reports site map in the Customer service workspace is shared between historical and real-time data model customization features. You'll be able to re-order the reports on both historical and real time admin pages. For both historical and real time, you'll be able to modify or delete reports added from the respective historical and real-time data model customization pages only.

### See also

[Customize the display of analytics reports](customize-reports.md#customize-the-display-of-analytics-reports)  
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md)  
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
