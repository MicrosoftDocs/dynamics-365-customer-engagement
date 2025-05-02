---
title: Enable and configure Sales qualification agent
description: Enable and configure the Sales qualification agent in Dynamics 365 Sales to help sellers leverage AI for effective lead qualification.
ms.date: 03/19/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
  - ai-gen-description
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Enable and configure Sales qualification agent

Help sellers leverage AI for lead research, [ideal customer profile (ICP)](sales-qualification-agent-faq.md#icp) fit assessment, and initial outreach email drafting. Configure the details about your company and products you sell, your ideal customer profile, and other settings. These configurations help align the agent with your company's sales strategy and goals.

## Prerequisites

Before you set up the agent, ensure that the following prerequisites are met:

- [Copilot Studio](/microsoft-copilot-studio/billing-licensing): Ensure that you have the Copilot Studio license and necessary capacity to run the agent. The agent uses the same capacity as other Copilot features in Copilot Studio. [Learn more about messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).

- [Copilot in Dynamics 365 Sales](enable-setup-copilot.md) (Optional but recommended): Turn on Copilot to include the [lead summary](copilot-get-information.md#summarize-a-lead) and [account summary](copilot-get-information.md#summarize-an-account) to get a 360-degree view of the lead and their company. 
- [New look](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle): Ensure that you enabled the new look for the Sales Hub app.

- Identify the products for which you want to configure the Sales qualification agent. Ideally, these products should be handled by a single sales team and have a similar ideal customer profile. For example, if your company sells multiple products through different sales teams, identify a product line and the corresponding sales team that the agent should help you with.  

<a name="grant-permissions"></a>
- Grant **User** level permissions **read**, **write**, **create**, **append**, **append to**, and **assign to** for the following entities to the seller's security role using the agent.

    - Sales Copilot Email Insight
    - Sales Copilot Insight
    - Sales Copilot Insight Card State

    :::image type="content" source="media/sqa-custom-role-permissions.png" alt-text="Screenshot of the permissions to be granted for a custom security role.":::

## How to set up and activate the agent

Setting up the Sales qualification agent requires collaboration between the tenant admin and the Dynamics 365 Sales admin. The tenant admin must first provide the necessary consents and configure capacity. Once these prerequisites are met, the Dynamics 365 Sales admin can proceed with configuring the agent to align with the company's sales strategy and goals.

The following steps describe how the tenant admin and the Dynamics 365 Sales admin can set up the agent.

<a name="open-the-sales-qualification-agent-settings-page"></a>
1. In the Sales Hub app, go to **Change area** in the lower left corner of the page and select **App Settings**.  
1. Go to **General Settings** > **Copilot** > **Agents (Preview)**.  
   The Welcome to Copilot agents (Preview) page appears.

1. In the **Before you get started** section, complete the following prerequisites as a tenant admin:
   - Grant consent for the agent to use Bing search and Copilot Studio.
   - Manage capacity for the agent to run in your environment. The agent uses the same capacity as other Copilot features in Copilot Studio. [Learn more about messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).
   
   If the required consents are already granted and capacity is configured, you'll directly see **Get started** when you open the **Agents** page.
   
1. Select **Get started** to configure the agent.  
   :::image type="content" source="media/sqa-configuration-page.png" alt-text="Screenshot of the Sales qualification agent configuration page.":::

1. In the **General** section, fill in details about your company, products you sell, and who should have access to the agent:

   | Field | Input | Example input |
   |-------------------------|-------------------------|----------------------------|
   | Team access | Select the security roles that exclusively represent sellers responsible for products that the agent will help with. Include the System administrator role explicitly if the admin also needs to see the insights. If you're selecting a custom role, ensure that [necessary permissions](#grant-permissions) are provided before adding it to the **Team access** list. | ContosoSalesTeam, System Administrator |
   | Company knowledge | Enter your company's name and website URL. The agent uses this information to tailor its research. | Company name: "Contoso Ltd." Website URL: "https://www.contoso.com" |
   | Value proposition of your offering | Describe the products that align with the products sold by sellers in the **Team access** list. | Cloud-based CRM solution that helps businesses streamline sales processes, improve customer relationships, and drive revenue growth. Our platform includes features such as lead management, opportunity tracking, email integration, and analytics.|

1. Adjust the [data refresh frequency](#adjust-the-frequency-of-research-data-refresh) in the **Data** section. By default, the data refresh frequency is set to **Medium**, which is ideal for most businesses.

1. In the **Research** section, review the resources that the agent uses to gather information about leads. The following sources are predefined and can't be edited:

   | Source | Description |
   |-------------------------|-------------------------|
   | Default basic research | Includes insights gathered from Copilot summaries, who knows whom, related opportunities, and so on. |
   | Default web research | Includes insights from predefined web resources to gather authentic information about the company's business, finances, and news. |

1. In the **Qualification** section, define your **Ideal customer profile** (ICP) to help the agent identify leads that are a good fit for further engagement. To understand the importance of ICP, see [What is ideal customer profile?](sales-qualification-agent-faq.md#icp). The following fields are available for you to configure:

   | Field | Input |
   |-------|-------|
   | Describe your ideal customer criteria | Specify the criteria for your ideal customer, such as industries you're targeting, company size, customer location, and job titles. |
   | Where to find this information | Verify the prepopulated fields from out-of-the-box Dataverse tables that'll be used for validating the criteria. If the fields are not relevant to your business, you can edit by adding or removing Dataverse fields. To add a custom criterion, see [add a custom criteria for ideal customer profile](#add-custom-criteria-for-ideal-customer-profile).|

   :::image type="content" source="media/sqa-ideal-customer-profile.png" alt-text="Screenshot of the ideal customer profile configuration.":::

1. Review all the settings to ensure that they align with your company's sales strategy and goals. 
1. Select **Activate** to activate the agent.
   If you don't have enough capacity to activate the agent, a banner appears at the top of the page, indicating the same. You can select the Power Platform admin center link in the banner to add more capacity or save the agent settings and come back later to activate the agent.

After the agent gets activated, it starts working on the last 100 leads, with the newly created leads processed first.

## Add custom criteria for ideal customer profile

Use custom criteria to define specific characteristics that are important for your [ideal customer profile](sales-qualification-agent-faq.md#icp). You can add custom criteria that are not available in the default list based on your custom fields from Dataverse or add public URLs that provide relevant information about the lead's company. For example, you could add a custom criterion for "Environmental Sustainability Initiatives" and map it to a custom field in Dataverse or provide a URL that lists the company's key environmental initiatives.  

1. In the Sales qualification agent settings page, scroll down to **Qualification** > **Ideal customer profile**.  
1. Select **Add custom criterion**.  
    :::image type="content" source="media/sqa-ideal-customer-profile-custom-criterion.png" alt-text="Screenshot of adding custom criterion to ideal customer profile configuration.":::
1. Enter the name of the custom criterion. Here the name is **Environmental Sustainability Initiatives**.  
1. Take one of the following actions as per your requirement:  

    - **Select Dataverse field(s)**: Select the option if you want to map the custom criterion to a field in Dataverse. This helps the agent to research and gather information based on the selected field.

    - **Or add public URL**: Select the option to provide a URL that contains information about the lead's company. The agent will use this URL to research and gather relevant information. The URL must be publicly accessible and not require any authentication.  

        1. In the text box, enter the company's URL.
        1. Select **Next**.
        1. In the **Provide instructions** dialog, add specific instructions on what information you want the agent to extract from the website. Also, you can add a Dataverse field to the instruction, enter the forward slash (**/**).  
            For example, you could say, "Look at the company's sustainability report and identify their key environmental initiatives /". The forward slash opens a dropdown list of available fields in the Dataverse table. Select a table and field from the list. 
            In this example, **Lead** > **Company Name** is selected. The instruction is now "Look at the company's sustainability report and identify their key environmental initiatives based on {{Lead.Company Name}}."  

            :::image type="content" source="media/sqa-ideal-customer-profile-custom-criterion-instruction.png" alt-text="Screenshot of adding an instruction to custom criterion to ideal customer profile configuration.":::

        1. Select **Add**.  
            The instruction is added to the custom criterion.

   The criterion is added to the list of ideal customer profile criteria.  

1. Enter the value for the custom criterion. For example, if the company should have at least three major environmental initiatives, enter **>=3**.  

## Adjust the frequency of research data refresh

By default, the research data is refreshed every three days. You can adjust the frequency of data refresh based on your business needs and available capacity.  

1. In the Sales qualification agent settings page, scroll down to **Data** > **Refresh options**.
1. Select the refresh option that's suitable for your business needs:
   - **High:** Data is refreshed every day. This option is ideal for businesses that need the latest information always. This option consumes more capacity.
   - **Medium:** Data is refreshed every three days. This option is suitable for businesses that need regular updates but don't require daily insights. This option balances performance and data accuracy.
   - **Low:** Data is refreshed every seven days. This option is suitable for businesses that don't need frequent updates and want to save capacity. This option consumes the least capacity.

## View usage consumption by the agent

You can start monitoring the usage consumption of the Sales qualification agent after the agent is published. This information helps you keep track of the capacity consumed by the agent and the remaining capacity. Learn more about [activities that consume Copilot Studio capacity](sales-qualification-agent-faq.md#what-activities-consume-copilot-studio-capacity).

1. From the Change area, select **App Settings** > **Copilot** > **Agents (Preview)**.
1. On the **Copilot agents** page, select **View usage consumption**. This option is only available after the agent is published.
   :::image type="content" source="media/view-usage-consumption.png" alt-text="Screenshot of the view usage consumption option.":::
   You're redirected to the **Licensing** page on Power Platform admin center.  
1. Under **Products**, select **Copilot Studio**.  
   The usage consumption by product, agent, and environment are displayed.

## Deactivate the agent

If you no longer want the Sales qualification agent to run in your environment or need to save capacity, you can deactivate it. When deactivated, new leads aren't processed, and existing lead insights aren't updated. However, insights already generated for existing leads will remain available.

1. [Open the Sales qualification agent settings page](#open-the-sales-qualification-agent-settings-page).
2. Scroll down to the bottom of the page.
3. Select **Deactivate**.

The agent's status changes to **Deactivating** until the process is complete. Once deactivated, the status changes to **Inactive**.