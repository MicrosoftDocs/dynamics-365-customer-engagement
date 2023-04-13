---
title: "Enable generation of quote and invoice documents| MicrosoftDocs"
description: "Help your sales team to generate quotes and invoices with consistent format and branding by using templates."
ms.date: 03/23/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Enable automatic generation of quote and invoice documents

Help your sales team to automatically generate quotes and invoice documents with consistent format and branding by using templates.

> [!IMPORTANT]
> This feature requires integration with SharePoint as the generated documents are stored in the SharePoint site. For more information, see [Configure Dynamics 365 Sales to integrate with SharePoint](connect-with-sharepoint.md). If you can't integrate with SharePoint, you can manually export the documents to PDF. For more information, see [Export sales records to PDF](create-quote-pdf.md).

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sales Professional Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Enable automatic document generation

> [!NOTE]
> Automatic document generation is only supported in Sales Professional.

1.  In the Sales Professional site map, select **Sales Settings**.

3.  Under **Advanced Settings**, select **Quote Settings**.

4.  To enable automatic generation of quote documents, in the **Quote to invoice** section, select the **Auto-generate quote as a Word document** check box, and then select the quote Word template from the drop-down list.

5.  To enable automatic generation of invoice documents, select the **Auto-generate invoice as a Word document** check box, and then select the invoice Word template from the drop-down list. All the out-of-the-box templates and the custom templates that you’ve created are available in the drop-down list.

6.  Select **Save**.
    
    The settings are saved. 

## Verify automatic document generation

When you activate a quote or invoice, a word document for the quote or invoice is automatically generated and stored in the SharePoint site that you've integrated with Dynamics 365. 

> [!NOTE]
> If you haven't integrated with SharePoint, the **Activate Quote** option will activate the quote but will not generate the document.

**To verify automatic document generation:**

1. In the site map, select **Quotes**. 
1. Open a quote in the **Draft** state and select **Activate Quote**.
1. Log into the SharePoint site that is integrated with Dynamics 365 Sales Professional.
1. Go to **Site Contents** and select **Account**.

    :::image type="content" source="media/sharepoint-site-small.png" alt-text="Screenshot showing the SharePoint site navigation to access the Account folder":::
    
1. Select the account for which you've activated the quote.
    You'll find the quote folder with the auto-generated quote document.


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
