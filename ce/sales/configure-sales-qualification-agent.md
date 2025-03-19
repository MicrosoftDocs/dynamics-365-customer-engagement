---
title: Enable and configure Sales Qualification Agent
description: Enable and configure the Sales Qualification Agent in Dynamics 365 Sales to help sellers leverage AI for effective lead qualification.
ms.date: 02/19/2025
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
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

# Enable and configure Sales Qualification Agent

Enable and configure the Sales Qualification Agent in Dynamics 365 Sales to help sellers leverage AI for lead research and qualification. 
Configure the details about your company and products you sell, your ideal customer profile, and other settings to align the agent with your company's sales strategy and goals.

## Prerequisites

The Sales qualification agent relies on existing Dynamics 365 Sales features to provide comprehensive research insights. While these features are not mandatory for the functioning of the agent, they enhance the agent's capabilities and provide a more holistic view of the lead and account.

- [Copilot in Dynamics 365 Sales](enable-setup-copilot.md): Turn on Copilot to include the [lead summary](copilot-get-information.md#summarize-a-lead) and [account summary](copilot-get-information.md#summarize-an-account) on the **Lead insights** page.
- [Bing search](/power-platform/admin/geographical-availability-copilot): Provide consent for Bing search so that the agent can fetch relevant information from external websites and include it in its research synthesis.
- [New look](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle): Ensure that you've enabled the new look for the Sales Hub app.

## Grant permissions to custom roles
<a name="grant-permissions"></a>

If you want to allow custom roles to access the agent, ensure that they have the necessary permissions.

Grant **User** level permissions for read, write, create, append, append to, and assign to the following entities:

- Sales Copilot Email Insight
- Sales Copilot Insight
- Sales Copilot Insight Card State

:::image type="content" source="media/sqa-custom-role-permissions.png" alt-text="Screenshot of the permissions to be granted for a custom security role.":::

## How to set up and activate the agent

1. In the Sales Hub app, go to **Change area** in the lower left corner of the page and select **App Settings**.
1. Go to **General Settings** > **Copilot** > **Agent (Preview)**.
1. Select **Get started**.

   The **Sales qualification agent** settings page opens.

   :::image type="content" source="media/sqa-configuration-page.png" alt-text="Screenshot of the Sales qualification agent configuration page.":::

1. In the **General** section, fill in details about your company, products you sell, and who should have access to the agent:

   | Field | Input |
   |-------------------------|-------------------------|
   | Team access | Select the security roles that need access to the agent, including the system administrator role. Typically, this includes sales roles responsible for lead qualification. If you're selecting a custom role, ensure that [necessary permissions](#grant-permissions) are provided before adding it to the Team access list. |
   | Company information | Enter your company's name and website URL. The agent uses this information to tailor its research. |
   | Products your team sells | Describe the products or services you sell in natural language. This helps the agent understand your offerings and generate lead qualification suggestions. Example product description: "We offer a cloud-based CRM solution that helps businesses streamline sales processes, improve customer relationships, and drive revenue growth. Our platform includes features such as lead management, opportunity tracking, email integration, and analytics." |

1. In the **Research** section, define your **Ideal customer profile** (ICP) to help the agent prioritize leads that match your target audience.

   | Field | Input |
   |-------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   | Describe your target customer criteria | Specify the criteria for your ideal customer, such as industries you're targeting, company size, customer location, and job titles. |
   | Where to find these criteria in Dataverse | Verify the prepopulated fields from out-of-the-box Dataverse tables that'll be used to validate the criteria. If you're using custom fields or table, select **Additional fields** to add the mapping. You can't delete mappings after they're added. |
   | Other suggested criteria to include | (Optional) Select additional criteria that you want the agent to consider and map them to the corresponding fields in Dataverse. |

   :::image type="content" source="media/sqa-ideal-customer-profile.png" alt-text="Screenshot of the ideal customer profile configuration.":::

1. Review all the settings to ensure that they align with your company's sales strategy and goals. You can always update the settings later.
1. Select **Publish** to publish and activate the agent.

> [!IMPORTANT]
> You can't deactivate the agent once it's activated. Contact Microsoft Support for deactivation. Alternatively, you can assign the agent to a role that's not used by any user to deactivate it.

After the agent gets activated, it starts working on the last 100 leads, with the newest created leads processed first.