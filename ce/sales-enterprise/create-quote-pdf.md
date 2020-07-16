---
title: "Create PDF files from sales records (Dynamics 365 Sales) | MicrosoftDocs"
description: "Create and share professional-looking PDF files with your customers."
ms.date: 05/21/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Create PDF files from sales records

Use the PDF generation capability to create and share read-only, professional-looking PDF files for Dynamics 365 records with your customers. The PDF file is generated using a standard Word template from your organization. The capability to create PDF files is available for the following entities: Account, Contact, Lead, Opportunity, Order, Quote, and Invoice.

If you opt in for the 2020 wave 2 release, apart from the entities listed earlier, the capability to create PDF file is supported on custom entities as well. 

Your system administrator can choose the entities for which PDF generation is enabled. If PDF generation isn't enabled, you won't see the option to create a PDF file. 

> [!IMPORTANT]
> - The PDF generation capability for additional entities (entities other than Quote) is released with Dynamics 365 Sales (Sales Hub) app version: 9.0.1911.1009, as part of the weekly release of the product to individual geographies.
> - With the August 2020 early access release, the PDF generation capability is extended to support all the out-of-the-box entities and custom entities that support Document templates.

## Steps for creating a PDF file (if you've opted in for 2020 wave 2 release)

1. Open the entity record for which you want to create a PDF file—in this example, a record for a Opportunity entity.
2. On the command bar, select **Export to PDF**.
    The **Export to PDF** dialog box appears.

    ![Export to PDF dialog box](media/export-to-pdf-dialog.png "Export to PDF dialog box")


    > [!IMPORTANT]
    > - Templates are available out of the box for the Account, Opportunity, Order, Quote, and Invoice entities. For entities that don't have out-of-the-box templates, you can create new templates. You can't create a PDF file for an entity record if there's no template available for that entity. To learn more about using Word templates, see [Use Word templates to create standardized documents](../admin/using-word-templates-dynamics-365.md). 
    > - If there are multiple Word templates available for the entity, by default, the first template in the list is automatically selected. A preview based on selected template is shown and the PDF document name is populated. 

3. In the **Save as** field, change the PDF document name, if required. 
4. If you'd like to use a different template than the one selected, in the **Select a template to generate PDF document** section, search for or select the template. 
    Once you select a template, the preview will be refreshed.
5. To download the PDF file to your computer, select **Download**.
6. To send the PDF file to your customer in email, select **Email**. 

    An email form opens with the following information is automatically populated.

    |Field             |    Populated with                                 |
    |------------------|-------------------------------------------------|  
    |**To**                |    Potential customer, if applicable                |
    |**From**                 |  The current user                                   |
    |**Attachments**       |    The generated PDF file, added as an attachment         |
    |**Regarding**           |  The record from which the email was triggered    | 
    |**Subject**             |  The title of the record      |

    ![Email form with PDF file attached](media/email-form-pdf-attachment.png "Email form with PDF file attached")

    > [!NOTE]
    > The Regarding field isn't populated if the 'Sending email' flag in the primary entity isn't enabled in the Customization area. For more information about this flag, see **Sending email** in the **Entity options that can only be enabled** section of [Edit an entity](/powerapps/maker/common-data-service/edit-entities#change-the-name-of-an-entity). 

7. To save the PDF file to a SharePoint site, select the **Save to SharePoint** button. This button is available when SharePoint integration is enabled for your organization and the **Document Management** check box is selected on the entity page in the Customization area. For more information about the Document Management check box, see [Enable or disable entity options](/powerapps/maker/common-data-service/edit-entities#enable-or-disable-entity-options)

8. To save the PDF file as a note to the primary record, select the **Save to Dynamics** button. This button is available if Notes is enabled for the primary entity. If you don't see the **Save to Dynamics** button, check whether the **Notes (includes Attachment)** check box is selected on the entity page in the Customization area. By default, notes is enabled on all out-of-the-box entities. For more information on the Notes check box, see **Notes** in the **Entity options that can only be enabled** section of [Edit an entity](/powerapps/maker/common-data-service/edit-entities#change-the-name-of-an-entity) 
 
> [!NOTE]
> The enhanced PDF capabilities available with the 2020 wave 2 release aren't supported on mobile devices. 


## Steps for creating a PDF file (if you haven't opted in for 2020 wave 2 features)

If you haven't opted in for the 2020 wave 2 features or if you're a using Sales Hub app on the mobile app, the capability for generating PDF is limited to the following entities: Account, Contact, Lead, Opportunity, Order, Quote, and Invoice. 

1. Open the entity record for which you want to create a PDF file&mdash;in this example, a record for a Quote entity.

2. On the command bar, select **Create PDF**, and then select the template you want to use to create the PDF. 

    > [!div class="mx-imgBorder"]
    > ![A quote form showing the Create PDF button on the command bar](media/create-pdf.png "A quote form showing the Create PDF button on the command bar")

    > [!IMPORTANT]
    > Templates are available out of the box for the Account, Opportunity, Order, Quote, and Invoice entities. For entities that don't have out-of-the-box templates, you can create new templates. You can't create a PDF file for an entity record if there's no template available for that entity. 

    > [!TIP]
    > To learn more about using Word templates, see [Use Word templates to create standardized documents](../admin/using-word-templates-dynamics-365.md). 

    You'll see a dialog box with options to save the PDF or download the PDF. 

    > [!div class="mx-imgBorder"]    
    > ![Option to save or download PDF file](media/save-or-download-pdf-document.png "Option to save or download a PDF file")
    
    If you select **Save**, the PDF file is stored in the default Microsoft SharePoint site if SharePoint is configured and enabled for the **Quote** entity. If SharePoint isn't configured, the **Save** option saves the PDF as a Notes attachment to the Quote record in Dynamics 365 Sales. The **Download** option downloads the PDF to your local drive. After it's downloaded, you can add this file to a note, send it as an attachment in an email, or upload it to SharePoint.

### Email a PDF file (if you haven't opted in for 2020 wave 2 features)**

You can also generate a PDF file and directly email it to a customer.

1. Open an entity record&mdash;in this example, a record for a Quote entity.

2. On the command bar, select **Email as PDF**, and then select a document template.

    ![A quote form showing the Email as PDF button on the command bar](media/email-as-PDF.png "A quote form showing the Email as PDF button on the command bar")

    In the email form that opens, the following information is automatically populated.

    |Field             |    Populated with                                 |
    |------------------|-------------------------------------------------|  
    |**To**                |    Potential customer, if applicable                |
    |**From**                 |  The current user                                   |
    |**Attachments**       |    The generated PDF, added as an attachment         |
    |**Regarding**           |  The record from which the email was triggered| 
    |**Subject**             |  The title of the record                                    |

3. Verify or change any details in the email form as necessary, and then select **Send**.

> [!IMPORTANT]
> The time taken to generate the PDF file and download or send the email depends on the size of the file. You'll see optimum performance when the file size is less than 2 MB. Larger files can require considerably more response time.

## FAQs

Here are some FAQs related to the PDF generation capability:

**Question:** What happens if more than one SharePoint document location is associated with a record? <br>
**Answer:** Regardless of the number of SharePoint document locations that exist for a record, the generated PDF file is always saved to the default location: \[<record_name>_<record_id>].<br>

**Question:** Can I specify a different name for the PDF file before generating it?<br>
**Answer:** IF you haven't opted in for the 2020 wave 2 features, then you can't specify a different file name.<br>

**Question:** Can I choose to save the PDF file to the Sales app as notes or to SharePoint? <br>
**Answer:** With the 2020 wave 2 release, you can choose to save the PDF file to the Sales app as notes or to SharePoint. However, if you haven't opted in for the 2020 wave 2 features, you can't choose. If SharePoint is enabled for the entity for which you are generating a PDF, then the PDF file will be saved to the SharePoint location by default. <br>

**Question:** Is the PDF generation capability available on all entities? <br>
**Answer** With the 2020 wave 2 release, the PDF generation capability is available on all the out-of-the-box entities and custom entities. If you haven't opted in for the 2020 wave 2 features or if you are using Sales Hub on a mobile device, the PDF generation capability is available only on seven out-of-the-box entities: Account, Contact, Lead, Opportunity, Quote, Order, Invoice.<br>

**Question:** Does the generated PDF file support custom fonts? <br>
**Answer:** The fonts in the generated file are limited to the fonts installed on the server that generates the PDF documents. Here's a list of supported fonts:

- Microsoft-Windows-Font-Bitmap-Courier
- Microsoft-Windows-Font-Bitmap-Fixed
- Microsoft-Windows-Font-Bitmap-MS_Sans_Serif
- Microsoft-Windows-Font-Bitmap-MS_Serif
- Microsoft-Windows-Font-Bitmap-OEM
- Microsoft-Windows-Font-Bitmap-Small
- Microsoft-Windows-Font-Bitmap-System
- Microsoft-Windows-Font-Bitmap-Terminal
- Microsoft-Windows-Font-FMS
- Microsoft-Windows-Font-RegistrySettings
- Microsoft-Windows-Font-StaticCache
- Microsoft-Windows-Font-TrueType-Arial
- Microsoft-Windows-Font-TrueType-ArialBlack
- Microsoft-Windows-Font-TrueType-Bahnschrift
- Microsoft-Windows-Font-TrueType-Calibri
- Microsoft-Windows-Font-TrueType-Cambria_Regular
- Microsoft-Windows-Font-TrueType-ComicSansMS
- Microsoft-Windows-Font-TrueType-Consolas
- Microsoft-Windows-Font-TrueType-CourierNew
- Microsoft-Windows-Font-TrueType-Ebrima
- Microsoft-Windows-Font-TrueType-EbrimaBold
- Microsoft-Windows-Font-TrueType-FontsRegistrySettingsMigration
- Microsoft-Windows-Font-TrueType-Gadugi
- Microsoft-Windows-Font-TrueType-Georgia
- Microsoft-Windows-Font-TrueType-Inkfree
- Microsoft-Windows-Font-TrueType-JavaneseText
- Microsoft-Windows-Font-TrueType-LeelawadeeUI_Regular
- Microsoft-Windows-Font-TrueType-LeelawadeeUI
- Microsoft-Windows-Font-TrueType-LucidaConsole
- Microsoft-Windows-Font-TrueType-MalgunGothic
- Microsoft-Windows-Font-TrueType-MicrosoftHimalaya
- Microsoft-Windows-Font-TrueType-MicrosoftJhengHei
- Microsoft-Windows-Font-TrueType-MicrosoftYaHei
- Microsoft-Windows-Font-TrueType-MongolianBaiti
- Microsoft-Windows-Font-TrueType-MVBoli
- Microsoft-Windows-Font-TrueType-MyanmarText
- Microsoft-Windows-Font-TrueType-NewTaiLue
- Microsoft-Windows-Font-TrueType-NirmalaUI_Regular
- Microsoft-Windows-Font-TrueType-NirmalaUI
- Microsoft-Windows-Font-TrueType-PhagsPa
- Microsoft-Windows-Font-TrueType-SegoePrint
- Microsoft-Windows-Font-TrueType-SegoeUI_Regular
- Microsoft-Windows-Font-TrueType-SegoeUI
- Microsoft-Windows-Font-TrueType-SimSun
- Microsoft-Windows-Font-TrueType-TaiLe
- Microsoft-Windows-Font-TrueType-TimesNewRoman
- Microsoft-Windows-Font-TrueType-TrebuchetMS
- Microsoft-Windows-Font-TrueType-Verdana
- Microsoft-Windows-Font-TrueType-Webdings
- Microsoft-Windows-Font-TrueType-Wingdings
- Microsoft-Windows-Font-TrueType-YiBaiti
- Microsoft-Windows-Font-TrueType-YuGothicMedium
- Microsoft-Windows-Font-Vector
- Microsoft-Windows-Type1-Fonts






### See also

[Enable or disable PDF generation from sales records](enable-pdf-generation-quote.md)  
