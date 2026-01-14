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

The agent engages with customers and drives sales by using structured product data and curated knowledge sources. This capability integrates product and sales collateral, like product documentation, FAQs, and internal playbooks, to enable the agent to provide accurate, context-aware responses to customer inquiries.  
Unlike generic web-based solutions, the agent uses organization-specific resources to answer questions, handle objections, and deliver tailored product information. This approach ensures compliance and consistency in customer interactions.  
This section explains how to configure knowledge sources to send replies, maximize the agent's effectiveness, and align its behavior with your organization's sales strategy.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

You can configure three types of knowledge sources for the Sales Close Agent - Engage: [Agent playbook](#agent-playbook), [Product documentation](#product-documentation), and [Product catalog](#product-catalog).

## Agent playbook

The agent uses the agent playbook to map intent from customer emails into specific intent groups and to understand the action plan required to fulfill each intent. Use the file upload feature to add the playbook to the agent.  
The basic structure of the playbook is as follows:  

- **Intent Group**: Organized into intent groups such as product details, comparisons, and discount requests.  
- **Intent**: Each intent group contains intent types and corresponding instructions for the agent.  
- **Agent Instructions**: These instructions are effective prompts that guide the agent’s tone and strategy.  
For example, if a customer asks about discounts, the playbook might instruct: *Avoid offering discounts unless explicitly approved; instead emphasize value and benefits.* 

Each product FAQ document should include a specific term representing the product, such as the product’s name, model number, or an alternate name. Set up this term in the **Product** entity. Configure the corresponding column in [the product details section](configure-sales-close-agent-product-details.md#product-name-to-search) as a search attribute, so the agent can easily locate the relevant product document. When you upload the playbook for the first time, the agent might take some time to process the files. Wait until the status changes to **Ready** before publishing the agent.  

>[!NOTE]
>
>- You can't modify the playbook file directly after uploading it. To make changes, download the file, update it as needed, upload the new version, and delete the older version.  
>- The agent uses the playbook to map customer intent to a specific intent group and then follows the corresponding instructions for that group.

## Product documentation

Product documentation enables the agent to answer technical questions, handle warranty queries, and suggest products based on features or specifications.  
Gather all technical and marketing documents for your products and store them in a dedicated SharePoint folder. Add this folder as a knowledge source to the agent using SharePoint folder sync. For more details on supported file types and size limits, refer to the Microsoft Learn documentation on unstructured data as a knowledge source.  

>[!NOTE]
>
>- Ensure the SharePoint folder contains documents for all products the agent is authorized to sell.  
>- Keep all files current and accurate to provide reliable information.  
>- Folders synced to Copilot Studio are updated automatically every four hours. Any changes such as new files, updates, or removals in SharePoint are reflected in Copilot Studio after the next sync.  

For more information about product documentation in Microsoft Copilot Studio, see [Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot).  

## Product catalog

The product catalog is based on the **Product** entity in Dataverse. Configure it at the agent level to help the agent retrieve the purchase URL for products.  
This knowledge source is already set up by default for the agent. To enhance the agent's ability to recognize custom attributes such as those containing purchase URLs, [configure synonyms and glossaries](/microsoft-copilot-studio/knowledge-add-dataverse#synonyms-and-glossary-terms). This increases the likelihood that the agent will correctly identify and extract purchase links, even if they are described in various ways.

## Configure knowledge sources

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. In the **Knowledge** section, select **Knowledge sources**.  
    :::image type="content" source="media/sca-knowledge-knowledge-sources-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Engage knowledge sources settings page.":::  
1. To configure **Agent playbook**:  
    1. In the **Agent playbook** section, the **Default Agent playbook** is provided to you by default and the location in your organization's SharePoint is specified in the **SharePoint Location** field.  

        >[!IMPORTANT]
        >Ensure that the sensitivity label of the playbook Excel file is set to **General** or **Public**. If the sensitivity is set to **Confidential** or higher, the agent might not access the playbook, leading to suboptimal performance during customer interactions. To learn more about sensitivity labels, read the [Enable sensitivity labels for files in SharePoint and OneDrive](/purview/sensitivity-labels-sharepoint-onedrive-files) article.  

    1. To open the playbook, select **Open**.  
        The playbook file opens in a new tab in Excel format.  
    1. To customize the playbook, open the playbook, customize it to match your organization's sales strategies, and save the file.  
        The playbook is saved in your default organization's SharePoint location and is ready to be used by the agent.  
    1. To change the location of the playbook after customizing it, select **Change location**.  
        In **SharePoint location**, enter the playbook location and save. Ensure the format for the SharePoint location is `https://<siteurl>/<foldername>/<filename>`. For example, `https://sharepoint.contoso.com/sites/salescloseagent/configuration/AgentPlaybook.xlsx`.  

    To learn about the playbook structure and how to customize it, read the [Agent playbook](#agent-playbook) section.  

1. <a name="configure-product-documentation"></a>To configure **Product documentation**:  
    1. In the **Product documentation** section, select **Manage**.  
    1. On the Microsoft Copilot Studio page, select **Add knowledge**, and then select **Upload file** to upload a file or folder from your local computer, or select **SharePoint** to upload from SharePoint.

        :::image type="content" source="media/sca-knowledge-product-documentation-manage-page.png" alt-text="Screenshot of the Sales Close Agent - Engage product documentation manage page.":::  

        To learn more about product documentation, read the [Product documentation](#product-documentation) article.  

1. To configure **Product catalog**:  
    1. In the **Product documentation** section, select **Manage**.  
        The **Product** entity in Dataverse is configured by default for the agent.  
    1. Open the **Product** entity and go to the **Synonyms** and **Glossary** tabs and add any custom attributes that contain purchase URLs or other relevant product information.  

    To learn more about the product catalog, read the [Product catalog](#product-catalog) article.

1. Publish the changes.  

>[!NOTE]
>Ensure you publish the agent after adding or updating knowledge sources for the changes to take effect.  

## Next step  

[Test the Sales Close Agent - Engage](sales-close-agent-engage-test.md)

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)  
[Add knowledge to an agent](/microsoft-copilot-studio/knowledge-add-existing-copilot)
