---
title: "Enable or disable generation of PDF from Dynamics 365 records (Dynamics 365 Sales) | MicrosoftDocs"
description: "Enable your users to create and share professional-looking PDF files with customers."
ms.date: 04/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---


# Enable or disable PDF generation from sales records

The PDF generation capability allows users to generate PDF files directly from Dynamics 365 records. The capability to create PDF files is supported on the following entities: Accounts, Contacts, Leads, Opportunities, Quotes, Orders, and Invoices. You can select the entities on which you want to enable PDF generation.

> [!IMPORTANT]
> With the August 2020 early access release, the PDF generation capability is extended to support all the out-of-the-box entities and custom entities that support Document templates.

1. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

2. In the site map, select **Overview**.

3. On the **Overview** page, under **Productivity tools**, select **Manage** for **Create, save and send pdf files on Dynamics 365 Sales records**.

4. On the **Convert to PDF** page, select the entities for which you want to enable the PDF generation capability.

    ![Convert to PDF settings](media/convert-to-pdf-setting-enhanced.png "Convert to PDF settings")

    - To see only the entities on which PDF generation is currently enabled, set the **Show only enabled entities** option to **Yes**.
    - To filter the list of entities and find a specific entity on which you want to enable PDF generation, use the **Filter by entity name** field. For example, to enable PDF generation on the Opportunity entity, type 'opp' and you'll see the entity name list filtered to show the entity names starting with 'opp'.  

5. Select **Save**.

### See also

[Create PDF files from sales records](create-quote-pdf.md)
