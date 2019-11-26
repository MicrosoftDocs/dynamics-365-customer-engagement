---
title: "Create PDF documents from sales records (Dynamics 365 Sales) | MicrosoftDocs"
description: "Create and share professional-looking PDF documents with your customers."
ms.date: 11/15/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Create PDF documents from sales records

Create and share professional-looking PDF documents for sales records by generating a PDF document using a standard template from your organization. 

The capability to create PDF documents is available on the following entities: Account, Contact, Lead, Opportunity, Order, Quote, and Invoice.

Your system administrator can choose the entities on which PDF generation is enabled. 

> [!IMPORTANT]
> - The PDF generation capability for additional entities (entities other than quote) is released with Dynamics 365 Sales (Sales Hub) app version: 9.0.1911.1009, as part of weekly release of the product to individual geographies.
> - If you do not see the **Create PDF** and **Email as PDF** options on one of the supported entity records, it might be because your system administrator hasn't enabled the PDF-generation capability for that entity. In this case, check with your system administrator.

1.	Open the entity record for which you want to create a PDF document. For example, open a quote record.

2.	On the command bar, select **Create PDF** and then select a template on which you want to create the PDF. 

    ![A quote form showing the Create PDF button on the command bar](media/create-pdf.png "A quote form showing the Create PDF button on the command bar")

    > [!IMPORTANT]
    > Templates are available out of the box for the Account, Opportunity, Order, Quote, and Invoice entities. For entities that do not have the out-of-the-box templates, you can create new templates. You can't create a PDF document for an entity record if there's no template available for that entity. 

    A PDF document using the selected template is downloaded to your computer. You can add this document to a note or send it as an attachment in email.

    > [!TIP]
    > To learn more about using Word templates, see [Use Word templates to create standardized documents](../admin/using-word-templates-dynamics-365.md). 

## Email as a PDF document

You can also generate a PDF document and directly email it to a customer.

1.	Open an entity record. For example, open a quote record.

2.	On the command bar, select **Email as PDF** and then select a document template.

    ![A quote form showing the Email as PDF button on the command bar](media/email-as-PDF.png "A quote form showing the Email as PDF button on the command bar")

    An email form opens. 
    
    The following information is automatically populated.

    |Field             |	Populated with                                 |
    |------------------|-------------------------------------------------|  
    |**To**                |	Potential customer, if applicable                |
    |**From**	             |  Current user                                   |
    |**Attachments**       |	The generated PDF, added as an attachment         |
    |**Regarding**	       |  Record from which the email was triggered| 
    |**Subject**	         |  Title of the record                                    |

3.	Verify and change any details in the email form, and then select **Send**.

> [!IMPORTANT]
> The time taken to generate the PDF document and download or send email is dependent on the size of the file. You'll see optimum performance when the file size is less than 2 MB. Larger files can require considerably more response time.

### See also

[Enable PDF generation from sales records](enable-pdf-generation-quote.md)  
