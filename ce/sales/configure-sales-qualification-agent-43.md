---
title: Set up the Sales Qualification Agent (pre-7.3 version)
description: Learn how to activate and set up the pre-7.3 version of the Sales Qualification Agent in Dynamics 365 Sales to help your sellers use AI for effective lead qualification.
ms.date: 07/24/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Set up the Sales Qualification Agent (pre-7.3 version)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

> [!NOTE]
> This article is for the version of Sales Qualification Agent that was part of the April 2025 public preview. The latest version of the agent is available in 9.0.25073.10001 (7.3) release. To know the version in your organization, check the **Server version** in **Settings** > **About** in the Sales Hub app. To check your deployment schedule, go to [Latest version availability](/dynamics365/released-versions/dynamics365sales#latest-version-availability) and look for the 9.0.25073.10001 version. If your org has the latest version, your existing  agent will be in the Draft mode and you must [reconfigure it](upgrade-sales-qualification-agent.md) to use the agent. Learn more about the latest version in [Sales Qualification Agent overview](sales-qualification-agent.md).

As an admin, you need to set up the Sales Qualification Agent before your sellers can use it for lead research, ideal customer profile (ICP) fit assessment, and initial email outreach. This article discusses how to configure the details about your company and products you sell, your ideal customer profile, and other settings to help the agent align with your company's sales strategy and goals.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Ensure that the following prerequisites are met:

- Your tenant admin has granted consent for the agent to use Bing search and Copilot Studio and assigned sufficient capacity to run the agent.
  Consent settings are available in the **General Settings** > **Copilot** > **Agents (Preview)** page in the Sales Hub app settings.

    The agent uses the same capacity as other Copilot features in Copilot Studio. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).

- You have admin permissions in Dynamics 365 Sales.

- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).

- You turned on the modern UI for the Sales Hub app. Learn more in [Enabling the modern look for my app and removing the toggle](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle).

- You modified Data Loss Prevention (DLP) policies to allow the following connectors:
  
    | Connector                                 | Why is it required?                                                                                   |
    |--------------------------------------------|-------------------------------------------------------------------------------------------------------|
    | Knowledge source with public websites and data | The agent needs it to access public data for enrichment.     |
    | Microsoft Copilot Studio                       | Copilot Studio is the core platform for building and deploying the agent.                      |
    | Knowledge source with SharePoint or OneDrive      | Required only if the agent is configured to use internal documents on SharePoint or OneDrive for enrichment.                         |
    | Knowledge source with documents                | Required only if the agent is configured to use internal documents for enrichment.                   |

   Learn more in [Configure data loss prevention policies for agents](/microsoft-copilot-studio/admin-data-loss-prevention).

- You configured server-side synchronization by integrating Dynamics 365 with Exchange. Learn more in [Set up email by integrating with Exchange](configure-email.md). If server-side synchronization isn't set up, the agent doesn't generate outreach emails.

- (Optional but recommended) You turned on Copilot in Dynamics 365 Sales to allow your sellers to get a 360-degree view of the lead and their company. Learn more in [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md) and [Get information from Copilot](copilot-get-information.md).

## Before you begin

Determine the products that you want the Sales Qualification Agent to help with and the [ideal customer profile (ICP)](sales-qualification-agent-faq.md#icp) for those products. The products should be handled by a single sales team and have a similar ideal customer profile. If your company sells multiple products through different sales teams, pick one product line.

<a name="grant-permissions"></a>

## Grant permissions to custom security roles

If you're using custom security roles for your sales team instead of the out-of-the-box **Salesperson** or **Sales Manager** role, you need to grant specific permissions to the custom roles. These permissions are necessary for sellers to access the insights generated and work on the leads handed over by the agent. Learn more about granting permissions in [Define the privileges and properties of a security role](/power-platform/admin/security-roles-privileges?tabs=new#define-the-privileges-and-properties-of-a-security-role).

You can either add the **Salesperson** or **Sales Manager** role to the users who'll be working on these leads or assign the following permissions to the custom security role:

| Purpose | Entity name (Logical name) | Permissions |
|---------|----------------------------|-------------|
| Access research insights | Sales Copilot Email Insight (msdyn_salescopilotemailinsight) <br> Sales Copilot Insight (msdyn_salescopilotinsight) <br> Sales Copilot Insight Card State (msdyn_salescopilotinsightcardstate) | **User**: Read, Write, Create, Append, Append To, Assign |
| Access leads handed over by the agent (Only for engage agent) | Sales Agent Handover (msdyn_salesagenthandover) | **Global**: Read <br> **Basic**: Append, Append To, Assign, Write, Create, Delete, Share |
| Access outreach emails generated by the agent | Email Activity (email) <br> Lead (lead) | **User**: Read, Create (Email Activity) <br> **User**: Append, Append To (Lead) |

The following image shows the permissions to access research insights as an example:

:::image type="content" source="media/sqa-custom-role-permissions-43.png" alt-text="Screenshot of the permissions to grant to a custom security role for use with the Sales Qualification Agent in Dynamics 365 Sales.":::


<a name="open-the-sales-qualification-agent-settings-page"></a>
## Set up and activate the agent

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Go to **General Settings** > **Copilot** > **Agents (preview)**.

   If the **Before you get started** section appears on the **Agents** page, it means that the required consents and capacity aren't configured. A tenant admin needs to complete the prerequisites before you can set up the agent.

   :::image type="content" source="media/sqa-configuration-page-43.png" alt-text="Screenshot of the Sales Qualification Agent settings page in Sales Hub Copilot agent settings.":::

1. In the **General** section, enter details about your company, products you sell, and who should have access to the agent. The following table describes the fields you need to fill out and provides example input.

   | Field | Input | Example input |
   |---|---|---|
   | Team access | Select the [seller security role](#grant-permissions) that you created or identified earlier. Also select the system administrator role if the admin needs to view the agent's insights. | ContosoSalesTeam, System Administrator |
   | Company info | Enter your company's name and website URL. | Contoso Ltd.; `https://www.contoso.com` |
   | Value proposition of your offering | Describe the products or product line that the sellers in the **Team access** list handle, in natural language. | A cloud-based CRM solution that helps businesses streamline sales processes, improve customer relationships, and drive revenue growth. Our platform includes features such as lead management, opportunity tracking, email integration, and analytics. |

1. In the **Research** section, review the resources that the agent uses to gather information about leads. The following sources are set for you and can't be edited:

   - Default basic research: Includes insights gathered from Copilot summaries, who knows whom, related opportunities, and so on.
   - Default web research: Includes insights from predefined web resources to gather authentic information about the company's business, finances, and news.

1. <a name="ideal-customer-profile"></a>To help the agent identify leads that are a good fit for further engagement, in the **Qualification** section, define your **Ideal customer profile**.

   - Enter or select the criteria that describe your target customer, including industries, company size, customer location, and job titles.
   - Under **Where to find these criteria in Dataverse**, verify the prepopulated fields from out-of-the-box Dataverse tables that the agent should look at to compare the criteria.
     > [!TIP]
     > If you're just testing the agent, you can create a simple ideal customer profile that includes only a few criteria, such as industry and job title. This setup makes it easier to create leads that match the profile and validate the agent's functionality. For example, you can set the industry to "Technology" and the job title to "Manager". After this profile succeeds, you can gradually add more criteria that are relevant to your business.

      If you want to use custom fields or tables, [add custom criteria to your ideal customer profile](#add-custom-criteria-to-your-ideal-customer-profile).

   :::image type="content" source="media/sqa-ideal-customer-profile-43.png" alt-text="Screenshot of the ideal customer profile configuration in Sales Qualification Agent settings.":::

1. Review the settings to make sure that they align with your company's sales strategy and goals.

1. Select **Activate**.

The status changes to **Active**. The agent starts processing the last 100 leads, starting with the most recently created ones. You can now test the agent to ensure it's working as expected. Learn more in [Test the Sales Qualification Agent](test-sales-qualification-agent-43.md).

The agent uses the capacity assigned to your tenant to process leads and generate insights. If you don't have enough capacity to activate it, a banner appears at the top of the page. Select the Power Platform admin center link in the banner to add more capacity, or save the agent settings and come back later to activate it.

## Add custom criteria to your ideal customer profile

Use custom criteria to define characteristics that are important for your ideal customer profile. You can map your criteria to custom fields in Dataverse or add public URLs that provide the relevant information. For example, you could add a custom criterion for "Environmental Sustainability Initiatives" and map it to a custom field in Dataverse or provide a URL that lists the company's key environmental initiatives.

1. On the [Sales qualification agent settings page](#set-up-and-activate-the-agent), scroll down to **Qualification** > **Ideal customer profile**.

1. Select **Add custom criterion**.  
    :::image type="content" source="media/sqa-ideal-customer-profile-custom-criterion-43.png" alt-text="Screenshot of adding custom criterion to ideal customer profile configuration.":::

1. Enter the name of the custom criterion. For example, enter **Environmental Sustainability Initiatives**.  
1. Tell the agent where to find the information to evaluate the custom criterion. You can choose one of the following options:

    - Select **Select Dataverse field(s)**, and then select the field that you want to map to the custom criterion.

    - Select **Or add public URL**, and then enter the URL of the website that provides the information. Make sure that the website is publicly accessible and doesn't require authentication.

1. If you added a URL, provide instructions for the agent to extract the information you're looking for.

    - Specify what information you want the agent to extract from the website. 
    - Select the Dataverse field that's most relevant to the information you want to extract by adding a forward slash (/).  
      For example, you could say, "Look at the company's sustainability report and identify their key environmental initiatives /". The forward slash opens a dropdown list of available fields in the Dataverse table.  Select a table and field from the list. In this example, Lead > Company Name is selected.  The instruction is now "Look at the company's sustainability report and identify their key environmental initiatives based on  {{Lead.Company Name}}."  

    :::image type="content" source="media/sqa-ideal-customer-profile-custom-criterion-instruction-43.png" alt-text="Screenshot of adding instructions for the custom criterion.":::

1. Select **Add**.  

1. Enter a value for the newly added custom criterion. For example, if the company should have at least three major environmental initiatives, enter >=3.

## View the agent's usage consumption

After the agent is published, you can start monitoring the capacity it consumes and how much capacity is left. Learn more in [What activities consume Copilot Studio capacity?](sales-qualification-agent-faq-43.md#what-activities-consume-copilot-studio-capacity) in the Sales Qualification Agent FAQ.

1. In the Sales Hub app **Change area**, select **App Settings** > **Copilot** > **Agents (preview)**.

   :::image type="content" source="media/view-usage-consumption.png" alt-text="Screenshot of the view usage consumption option.":::

1. On the **Copilot agents** page, select **View usage consumption**. You're redirected to the **Licensing** page in the Power Platform admin center.

    This option is available only after the agent is published.

1. on the **Licensing** page, under **Products**, select **Copilot Studio**.

   The page displays usage consumption by product, agent, and environment.

## Deactivate the agent

If you no longer want the Sales Qualification Agent to run in your environment or need to save capacity, you can deactivate it.

When the agent is deactivated, it doesn't process new leads or update existing lead insights. However, insights it already generated remain available.

1. [Open the Sales Qualification Agent settings page](#set-up-and-activate-the-agent).
2. Scroll down to the bottom of the page.
3. Select **Deactivate**.

The agent's status changes to **Deactivating** until the process is complete. Once deactivated, the status changes to **Inactive**.

## Related information

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq-43.md)
- [Work on leads researched by Sales Qualification Agent (pre-7.3 version)](use-sales-qualification-agent-43.md)
