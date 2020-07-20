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

The PDF generation capability allows users to generate PDF files directly from Dynamics 365 records. You can select the entities on which you want to enable PDF generation. 

> [!IMPORTANT]
> With the 2020 wave 2 early access release, the PDF generation capability is extended to support all the out-of-the-box entities and custom entities.

## Enable or disable PDF generation (If you have opted in for 2020 wave 2 features)

1. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

2. In the site map, select **Overview**.

3. On the **Overview** page, under **Productivity tools**, select **Manage** for **Convert to PDF**.

    ![Convert to PDF setting on the Overview page](media/convert-to-pdf-option.png "Convert to PDF setting on the Overview page")

4. On the **Convert to PDF** page, select the entities for which you want to enable the PDF generation capability.

    > [!div class="mx-imgBorder"]
    > ![Convert to PDF settings](media/convert-to-pdf-setting-enhanced.png "Convert to PDF settings")

    1. To see only the entities on which PDF generation is currently enabled, set the **Show only enabled entities** option to **Yes**.  
    2. To filter the list of entities and find a specific entity on which you want to enable PDF generation, use the **Filter by entity name** field. For example, to enable PDF generation on the Opportunity entity, type 'opp' and you'll see the entity name list filtered to show the entity names starting with 'opp'.  

5. Select **Save**.

After you enable PDF generation, sellers will be able to generate a PDF, download it to their local computer, save it to Dynamics 365 as Notes or save it to SharePoint. 

> [!IMPORTANT]
> - The **Save to SharePoint** button is available to users when SharePoint integration is enabled for your organization and the **Document Management** check box is selected on the entity page in the Customization area. If they don't see the button, make sure that SharePoint integration and Document Management is enabled. For more information about the Document Management check box, see [Enable or disable entity options](/powerapps/maker/common-data-service/edit-entities#enable-or-disable-entity-options).
> - the **Save to Dynamics** button is available to users when Notes is enabled for the primary entity. If they don't see the button, make sure the **Notes (includes Attachment)** check box is selected on the entity page in the Customization area. By default, notes is enabled on all out-of-the-box entities. For more information on the Notes check box, see **Notes** in the **Entity options that can only be enabled** section of [Edit an entity](/powerapps/maker/common-data-service/edit-entities#change-the-name-of-an-entity) 


## Enable or disable PDF generation (If you haven't opted in for 2020 wave 2 features)

If you haven't opted in for 2020 wave 2 features, you can enable the capability to create PDF files only on the following entities: Accounts, Contacts, Leads, Opportunities, Quotes, Orders, and Invoices.

1. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

2. In the site map, select **Overview**.

3. On the **Overview** page, under **Productivity tools**, select **Manage** for **Create, save and send pdf files on Dynamics 365 Sales records**.

4. To enable or disable PDF generation, on the **Convert to PDF** page, set the entity toggle to **Enabled** or **Disabled**. For example, if you want to enable PDF generation on Opportunity records, set the **Opportunity** toggle to **Enabled**.  

    > [!div class="mx-imgBorder"]    
    > ![Convert to PDF settings](media/convert-to-pdf-setting.png "Convert to PDF settings")

5. Select **Save**.

### See also

[Generate PDF files from sales records](create-quote-pdf.md)
