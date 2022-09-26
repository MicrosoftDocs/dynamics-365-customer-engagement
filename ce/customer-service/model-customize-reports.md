---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using the Power BI embedded editing experience."
ms.date: 09/23/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Model customization of historical analytics reports in Customer Service (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

Dynamics 365 Power BI extensibility capability enables power users to extend out-of-box customer service Power BI data model and integrate with other data sets to produce new custom metrics.

Customizing the out-of-the-box standard reports and adding your own KPIs and custom metrics to the reports will enable you to view the key metrics that are relevant to your organization.

Key capabilities of model customization include the ability to:

- Edit out-of-the-box data model and add new metrics in addition to the out-of-the-box metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from the Customer Service workspace.

You can add your own dataset to build new custom metrics or drill-down to add your metrics to the report as required by your organization.

This topic describes how to enable the data model customization feature and set up the workspace for Microsoft to provision out-of-the-box data model in a Read-only workspace, and a workspace where the customized report can be published to render it in the Customer Service workspace.

## Prerequisites

- Have at least one of the historical reports enabled for Customer service manager, Omnichannel.
- Have access to Power BI for Microsoft service account.
- You must have administrative privileges for Dynamics 365 Customer Service and Power BI.
- You must have a Power BI Professional or Power BI Premium license for all supervisors and administrators.
- As a system administrator, you must create and add a security group for Power BI service. Perform the following steps to create and add a security group: 
  1. Create a security group in Azure Active Directory (Azure AD), and add Dynamics CCA Data Analytics as a member to that security group.  
More information: [Create a basic group and add members using Azure Active Directory](/azure/active-directory/fundamentals/how-to-manage-groups).
  2. As a Power BI administrator, enable the service principal in the Developer settings in the Power BI admin portal and the security group that you created in Azure AD.

     1. Sign in to Power BI service and go to **Settings** > **Admin portal**.
     2. In the **Admin portal**, go to **Tenant settings** > **Developer settings** > **Allow service principals to use Power BI APIs**.
     3. Enable **Allow service principals to use Power BI APIs**.
     1. Specify the security group to which you want to give access by selecting **Specify the security groups (Recommended)** option.
     1. Select **Apply**.

The following section describes a step-by-step process that explains how you can enable model customization of your historical analytics reports.

### Enable the Embedded Power BI report extensibility - Historical data model customization (preview) option

You need to enable the option to be able to extend the out of box Power BI data model and add new metrics to your reports.

 1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
 1. On the **Insights** page, **Report settings** section, for **Embedded Power BI report extensibility - Historical data model customization (preview)**, select **Manage**.
 1. On the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, set the **Enable embedded Power BI data model customization** toggle to **On**.
 
Once you have enabled the **Embedded Power BI report extensibility - Historical data model customization (preview)** option, there are steps that you need to perform to complete the process.
 
### Step 1: Select a Power BI workspace for historical analytics

(Add a one-liner on why you need to do this step)

 You can either select a workspace from the dropdown list and select **Save** or create a new workspace. Selecting a workspace helps define the place where your customized reports will be published.

To create a new workspace:
 1. Select **Create new workspace**.
 1. In the Create Power BI workspace dialog, provide a workspace name and select **Create**.
 1. Select **Save**. The report provisioning process is initiated.

> [!NOTE]
> The report will be provisioned in your Power BI tenant and not in Microsoft Power BI tenant. A hidden workspace will be created where the data set will be hosted, which will connect to Power BI. The report will be provisioned in your workspace and the Power BI files will be published into this workspace.      
> Note that this dataset is maintained by Dynamics Customer Service and is refreshed on a daily basis. It is recommended to not make changes to this dataset, otherwise it will lead to the report malfunction.

### Step 2: Grant permissions for data set and reports

Once the report provisioning process is complete, perform the following steps to grant authoring (read/write) permissions for power users and read permissions for supervisors.

1. Select **Give permissions to access out of the box Power BI Data model**.

1. Share the report by selecting the **Share** button. More information: [Share access to a dataset (preview)](/power-bi/connect-data/service-datasets-share)

1. Select **Give permissions to customize Power BI Report**. This will take you to the workspace in Power BI where the sample reports will be provided. These reports are the copy of your out-of-the-box reports. You can make changes to the reports. More information: [Enable model customization of your analytics reports from Power BI workspace](#enable-model-customization-of-your-analytics-reports-from-power-bi-workspace)

1. Select **Share dataset**.
1. On the **Share dataset** dialog box, search for the recipients name or email address.
1. Select the checkboxes for the various permissions that you want to set for the recipient.
1. Select **Grant accesss.**

### Step 3: Embed customized report from Power BI workspace to Dynamics 365

(Add a one-liner on why you need to do this step) On this step, you will be able to select the reports you want to see onteh site map.

1. Select **Add report**, which will take you to the Power Bi Desktop.
1. From **Common data sources**, select **Power Bi data sets** to create a live connection to datasets in the Power BI service.
1. On the **Select a dataset to create a report** dialog, select the report you want to embed to customer service.
1. On the **Connect to your data** dialog, select the database or the specific tables that you want to connect to. You can add up to 40 reports. 
1. Select **Submit**.
1. On the **Publish to Power BI** dialog, select a destination where you want your reports to be published and then select **Select**.
1. Provide a name and select **Add**.
1. Go to Customer Service workspace and select **Customized Reports**. Your reports will be rendered in teh Customer Service workspace.
1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, step 3, select **Add report**.

 
## Step 4: Render reports in Customer Service workspace

(Add a one-liner on why you need to do this step)

1. In the Customer Service workspace site map, select the Plus icon.
1. Select **Customized reports** from the dropdown list and then select teh report that you want to view.

TBD

## Enable model customization of your analytics reports from Power BI workspace

This section describes how you can update the out-of-the-box Power BI data model and add external datasets to build new custom metrics and publish it into your Power BI workspace.  

1. Open power BI report from the workspace.

2. Connect new data set from an excel sheet.

3. Update the out-of-the-box data model and differentiate the queue by departments.

4. Build a report specific for departments.

5. Publish the report to the Power BI workspace configured.

## Data model

This section describes the out of box data model for Dynamics 365 customer service, that you can use for specific areas:



## Out of box Power BI reports mapping

This section provides a mapping of the Power BI files and the respective reports that will be rendered.




### See also

[Visual customization of historical analytics reports in Customer Service](customize-reports.md#visual-customization-of-historical-analytics-reports-in-customer-service)
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md) <br>
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md) <br>
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md) <br>
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
