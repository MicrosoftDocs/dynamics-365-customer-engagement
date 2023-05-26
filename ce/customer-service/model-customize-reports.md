---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using Power BI."
ms.date: 05/25/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
---

# Customize data models of historical analytics reports in Customer Service

Use the extensibility feature in Microsoft Power BI  to extend the out-of-the-box Dynamics 365 Customer Service Power BI data model and integrate with other datasets to create new custom metrics. You can customize the out-of-the-box standard reports and add your own KPIs and custom metrics to the reports to view the key metrics that are relevant to your organization. You can also drill down to add your metrics to the report as required.

The key capabilities of model customization include the ability to:

- Edit the out-of-the-box data model and add new metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from Customer Service workspace.

You can enable data model customization for historical analytics reports from the Customer Service admin center. You'll need to perform the following steps.

1. Identify a Power BI workspace
1. Provision the data models and copy of reports
1. Grant permissions for data set and reports
1. Embed customized reports back to Dynamics 365
    
## Prerequisites

Before you begin, you must complete the following prerequisites:

- Enable insights features in Dynamics 365 Customer Service: You must enable at least one of the historical reports (customer service historical analytics, Omnichannel historical analytics or knowledge analytics) for the Customer Service Manager role in Omnichannel for Customer Service. More information: [Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md)  

- Enable Power BI service features from the Power BI admin portal. The Power BI administrator must enable the following:  

     - **Create workspace (new workspace experience)**: The configuration process creates two workspaces; a managed workspace and a customer workspace to deploy Dynamics data model and reports. More information: [Create workspaces (new workspace experience)](/power-bi/admin/service-admin-portal-workspace#create-workspaces-new-workspace-experience)

    - **Allow service principals to use Power BI APIs**: The configuration process leverages the Power BI APIs for creating workspaces, deploying reports and models. More information: [Enable service principals](/power-bi/enterprise/service-premium-service-principal#enable-service-principals)  

    - **Allow DirectQuery connections to Power BI datasets**: When report authors build new metrics or bring additional data sources, they will create composite models which requires DirectQuery enabled. More information: [Managing composite models on Power BI datasets](/power-bi/transform-model/desktop-composite-models#managing-composite-models-on-power-bi-datasets)

- Provide **Dynamics 365 service principal** access to Power BI.  

- Your Azure Active Directory administrators must create a security group in Microsoft Azure Active Directory with a preferred name of your choice. Add **Dynamics 365 Analytics** as a member of this security group. More information: [Create a basic group and add members using Azure Active Directory](/azure/active-directory/fundamentals/active-directory-groups-create-azure-portal)

The out-of-box **Service Principal Dynamics 365 Analytics** is leveraged to deploy the data model and make changes to the Power BI workspace on behalf of Dynamics 365 Customer Service. Permissions within Power BI can be granted only to groups and not individual service principals, and therefore a group needs to be created.

> [!NOTE]
> In organizations where Dynamics 365 Analytics may not be available, use Dynamics CCA Data Analytics.

- Power BI administrators must add the security group created in Azure Active Directory to Power BI service settings enabled earlier.

    - **Service Principal** in the **Developer settings**.
    - Create **workspaces** in the **Tenant settings**.

## Enable Power BI data model customization

 1. In the Customer Service admin center site map, select **Insights** in **Operations**.
 1. On the **Insights** page in the **Report settings** section, for **Embedded Power BI extensibility - Data model customization**, select **Manage**.
 1. On the **Embedded Power BI extensibility - Data model customization** page, switch the **Enable embedded Power BI data model customization** toggle to **On**.
 
## Identify a Power BI workspace

Specify the Power BI workspace where the Dynamics data model and reports will be provisioned. If you prefer to use an existing workspace, you can select the workspace from the  drop-down list, or create a new workspace by selecting **Create new workspace**. After you have made your selection, select **Save**. This initiates the provisioning of the reports.

> [!NOTE]
> This applies only to the customer's workspace. A new managed workspace will be created by Microsoft for historical reports when configured. For more information, go to: Understand how model customization works.

## Provision the data models and copy of reports

It could take up to 24 hours for the provisioning to complete. Select **Refresh** to check the provisioning status.

## Grant permissions for data set and reports

After the report is provisioned, you must provide **Write** permissions for users who will be authoring reports in Power BI and **Read** permissions for supervisors and other consumers of the reports.

You'll need to be a **Workspace Administrator** on both managed and customer workspaces (configured on the step 1) in Power BI to complete this step. By default, the user who starts the provisioning (step #2) will have the necessary permissions added.

  :::image type="content" source="media/enable-model-step2.png" alt-text="Grant permissions for data set and reports":::

### Grant access to the Power BI data model

Report authors will connect to this data model to build custom reports. When you select the **Power BI Data model** link, the managed workspace opens up and the details of the data model are displayed. Use the **Share** dialog to provide access to users by entering their email address. More information: [Share access to a dataset](/power-bi/connect-data/service-datasets-share).

You need to:

- Provide Report Authors with **Allow recipients to build content with the data associated with this dataset**.

- For report viewers like supervisors, you may choose to share the dataset without providing any additional permissions.

### Grant access to the customizable reports (optional)

When you select the **Customized Power BI Report** link, the Power BI workspace where the sample reports will be provided appears in a lineage view. These reports are the copy of your out-of-the-box reports and can be edited and modified. You'll have to provide access to the workspace only if your organization plans on using these copies to develop reports.

From the lineage view, select **Manage access**, and provide **Contributor** access to your report authors and **Viewer** access to users who will be viewing these or any other reports built in this workspace. You'll have to provide these permissions only if you plan to use these reports.

## Embed customized reports back to Dynamics 365

After your Report Authors have created and published the customized reports, you can allow Dynamics users to access these reports from the Customer service workspace by selecting the **Add report** dialog.

You'll be able to select the Power BI report in the workspace using the **Select Power BI report** dropdown and  enter a preferred name in the **Report name** text box. The drop-down list is populated with the reports in the workspace configured on Step 1. This preferred name will appear for your Dynamics users when they access the reports. When you are done entering these details select **Add** and then **Save**. You can add a maximum of 40 reports.

> [!NOTE]
> The customized reports site map in the Customer service workspace is shared between historical and real-time model customization features. You'll only be able to modify or delete reports added from the historical customer service model customization page. You'll be able to re-order the reports on both the admin pages.  

## View reports in Customer Service workspace

1. In the Customer Service workspace site map, select the **+** (plus) icon.
1. Select **Customized reports** from the dropdown list, and then select the report that you want to view.

### See also

[Customize the display of analytics reports](customize-reports.md#customize-the-display-of-analytics-reports)
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md)  
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
