---
title: Configure knowledge sources for Sales Close Agent - Engage
description: Configure the knowledge sources that the Sales Close Agent - Engage uses to provide relevant information and context during customer interactions.
ms.date: 11/07/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure knowledge sources for Sales Close Agent - Engage

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The agent's core function is to engage with customers and drive sales using structured product data and curated knowledge sources. This capability integrates product and sales collateral, like product documentation, FAQs, and internal playbooks, to enable the agent to provide accurate, context-aware responses to customer inquiries.  
Unlike generic web-based solutions, the agent uses organization-specific resources to answer questions, handle objections, and deliver tailored product information. This approach ensures compliance and consistency in customer interactions.  
This section explains how to configure knowledge sources to send replies, maximize the agent's effectiveness, and align its behavior with your organization's sales strategy.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Two types of knowledge sources are available for you to configure for the Sales Close Agent - Engage&mdash;[Agent playbook](#agent-playbook) and [Product documentation](#product-documentation).

## Agent playbook

Defines how the agent behaves during customer interactions. It acts as a set of sales tactics and response guidelines for different scenarios, ensuring the agent aligns with the organization’s preferred approach.  
Although the product documentation provides factual product information, the playbook dictates how to communicate and persuade customers. It controls how the agent responds to specific customer questions or objections, such as inquiries about discounts, competitor comparisons, refunds, or product details.
By default, a playbook&mdash;the **Default Agent playbook** excel file is provided to help you get started and the SharePoint location in your organization is specified in the **SharePoint Location** section. You can download the default playbook, customize it to suit your organization's sales strategies, and then upload it back to the SharePoint location by providing the updated SharePoint location in the settings page.  

The basic structure of the playbook is as follows:  

- **Intent Group**: Organized into intent groups such as product details, comparisons, and discount requests.  
- **Intent**: Each intent group contains intent types and corresponding instructions for the agent.  
- **Agent Instructions**: These instructions are effective prompts that guide the agent’s tone and strategy.  
For example: If a customer asks about discounts, the playbook might instruct: *Avoid offering discounts unless explicitly approved; instead emphasize value and benefits.*  

>[!NOTE]
>
>- The default playbook is a template that evolves over time. It's designed to help you get started quickly, and it might be updated to include best practices and improvements. Open the **Default Agent playbook** file and review the latest content.  
>- Don't use the default playbook as-is in production scenarios. Instead, customize it to align with your organization's specific sales strategies and customer engagement approaches.  

## Product documentation

Microsoft Copilot Studio provides resources for the agent to generate accurate and context-aware responses through **product documentation**. The resources function as content repositories from which the Copilot retrieves information to produce its answers. 

>[!NOTE]
>Product names in the documentation should match [the product names](configure-sales-close-agent-product-details.md#product-name-to-search) in your product catalog to ensure accurate retrieval of information.  
Knowledge sources are structured or unstructured content repositories that your Copilot can reference during conversations. They typically include:  

- Internal documents such as Word, PDF, and PPT.  
- Knowledge bases such as SharePoint sites and Dataverse tables.  
- Product catalogs and CRM data.  
- External URLs and public documentation.  

To understand more about product documentation in Microsoft Copilot Studio, read the [Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot) article.  

## Configure knowledge sources

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. In the **Knowledge** section, select **Knowledge sources**.  
    :::image type="content" source="media/sca-knowledge-knowledge-sources-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Engage knowledge sources settings page.":::  
1. To configure **Agent playbook**:  
    1. In the **Agent playbook** section, the **Default Agent playbook** is provided to you by default and the location in your organization's SharePoint is specified in the **SharePoint Location** field.  

        >[!IMPORTANT]
        >Ensure that the sensitivity label of the playbook excel file is set to **General** or **Public**. If the sensitivity is set to Confidential or higher, the agent might not access the playbook, leading to suboptimal performance during customer interactions. To learn more about sensitivity labels, read the [Enable sensitivity labels for files in SharePoint and OneDrive](/purview/sensitivity-labels-sharepoint-onedrive-files) article.  

    1. To open the playbook, select **Open**.  
        The playbook file opens in a new tab in excel format. Review the playbook structure and if you're satisfied with the default playbook, you can use it as-is.  
    1. To customize the playbook, open the playbook, customize to match your organization's sales strategies, and save the file.  
        The playbook is saved in your default organization's SharePoint location and ready to be used by the agent.  
    1. To change the location of the playbook after customizing it, select **Change location**.  
        In **SharePoint location**, enter the playbook location and save. Ensure the format for the SharePoint location is `https://<siteurl>/<foldername>/<filename>`. For example, https://sharepoint.contoso.com/sites/salescloseagent/configuration/AgentPlaybook.xlsx.  
    To understand the playbook structure and how to customize it, read the [Agent playbook](#agent-playbook) section.  
1. To configure **Product documentation**:
    1. In the **Product documentation** section, select **Manage**.  
    1. In the Microsoft Copilot Studio page, select **Add knowledge** and then add the relevant knowledge sources that contain product documentation for the agent to use.  
        Knowledge sources include internal documents, knowledge bases, product catalogs, CRM data, external URLs, and public documentation.  
        Add knowledge sources using SharePoint file upload or local file upload. Place all required documents in a folder and sync the folder from SharePoint. The Dataverse entity for the product catalog is configured in the agent by default. If the product URL uses a different attribute, configure it in the synonyms.  
    To understand more about product documentation, read the [Product documentation](#product-documentation) article.  

## Next step 

[Start the Sales Close Agent - Engage](start-sales-close-agent.md)  

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)  
[Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot)

