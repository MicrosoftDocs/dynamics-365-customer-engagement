---
title: "Create a quote PDF (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Create and share a professional-looking quote PDF with your customers."
keywords: "Quote, proposal, create PDF, email PDF, PDF"
ms.date: 04/10/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1.x"
ms.assetid: f37196fb-0b42-4637-9700-acbbac25d9e6
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 58
topic-status: Drafting
---

# Create a quote PDF

Applies to Dynamics 365 for Customer Engagement apps version 9.1.x

Create and share a professional-looking quote PDF from a standard template that your organization uses.


> [!IMPORTANT]
> The **Create PDF** and **Email as PDF** options are available only if your system administrator has enabled the PDF generation capability for your organization. If you do not see these options, please talk to your system administrator.

1.	Open a quote record.

2.	On the command bar, select **Create PDF**, and then select the quote template. 

    ![A quote form showing the Create PDF button on the command bar](media/create-pdf.png "A quote form showing the Create PDF button on the command bar")

    A PDF using the selected template is downloaded to your computer. You can add this document to a note or send it as an attachment in an email or upload it to SharePoint.

    > [!TIP]
    > To learn more about using Word templates, see [Use Word templates to create standardized documents](../admin/using-word-templates-dynamics-365.md) 

## Email as PDF

You can also generate a PDF and directly email it to a customer.

1.	Open the quote record.

2.	On the command bar, select **Email as PDF**, and then select the quote template.

    ![A quote form showing the Email as PDF button on the command bar](media/email-as-PDF.png "A quote form showing the Email as PDF button on the command bar")

    An email form opens. 
    
    The following information is automatically populated:

    |Field             |	Populated with                                 |
    |------------------|-------------------------------------------------|  
    |To                |	Potential customer of the quote                |
    |From	             |  Current user                                   |
    |Attachments       |	The generated PDF, added as attachment         |
    |Regarding	       |  Quote record from which the email was triggered| 
    |Subject	         |  Quote title                                    |

3.	Verify and change any details in the email form, and select **Send**.


### See also

[Enable PDF generation from Quotes](enable-pdf-generation-quote.md)  
[Create or edit a quote](create-edit-quote-sales.md)