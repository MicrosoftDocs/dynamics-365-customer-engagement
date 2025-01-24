---
title: "Enable or disable PDF generation from records | MicrosoftDocs"
description: "Enable your users to create and share professional-looking PDF files for entity records with customers."
ms.date: 01/23/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# Enable or disable PDF file generation from sales records 

Enable your users to create and share professional-looking PDF files of the sales entity records with customers.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Enable or disable PDF generation

The PDF generation capability allows users to generate PDF files directly from Dynamics 365 records. The capability to create PDF files is supported for the following entities: Accounts, Contacts, Leads, Opportunities, Quotes, Orders, and Invoices, on both web and mobile apps. You can select the entities on which you want to enable PDF generation. 

Depending on the Dynamics 365 Sales license you have, select one of the following tabs for specific information:

> [!IMPORTANT]
> With the 2020 release wave 2, the PDF generation capability is enhanced to support all custom entities. The PDF enhancements are limited to the web experience and aren't available in the mobile app. If you haven't opted in, or you're using Sales Hub on the mobile app, you'll see the old experience.

# [Sales Premium or Sales Enterprise](#tab/sales)

**To enable or disable PDF generation**:

1. In lower-left corner of the screen, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**.

2. In the site map, select **Overview** and search for **Convert to PDF** in the search box. Alternatively, you can select **Productivity tools** and then select **Convert to PDF**.

4. On the **Convert to PDF** page, select the entities for which you want to enable the PDF generation capability.

    :::image type="content" source="media/convert-to-pdf-setting-enhanced.png" alt-text="Screenshot of the Convert to PDF page":::

    1. To see only the entities on which PDF generation is currently enabled, turn on the **Show only enabled entities** toggle.  
    2. To filter the list of entities and find a specific entity on which you want to enable PDF generation, use the **Filter by entity name** field. For example, to enable PDF generation on the Opportunity entity, enter **opp** and you'll see the entity name list filtered to show the entity names starting with *opp*.  

5. Select **Save**.  
   PDF generation is enabled for the selected entities.

6. Review the out-of-the-box templates and create new templates as per your requirement. For more information, see [Create and manage Word templates](manage-word-templates.md). 
    > [!NOTE]
    > You can't create a PDF file for an entity record if there's no template available for that entity.

After you enable PDF generation, sellers will be able to generate a PDF, download it to their local computer, save it to Dynamics 365 as Notes or save it to SharePoint. 

> [!IMPORTANT]
> - The **Save to SharePoint** button is available to users when SharePoint integration is enabled for your organization and the **Document management** check box is selected on the entity page. If they don't see the button, make sure that SharePoint integration and document management are enabled. For more information about the **Document Management** check box, see [Enable or disable entity options](/powerapps/maker/common-data-service/edit-entities#enable-or-disable-entity-options).
> - The **Save to Dynamics** button is available to users when **Notes** is enabled for the primary entity. If they don't see the button, make sure the **Notes (includes Attachment)** check box is selected on the entity page in the **Customization** area. By default, notes are enabled on all out-of-the-box entities. For more information about the **Notes** check box, see [Entity options that can only be enabled](/powerapps/maker/common-data-service/edit-entities#entity-options-that-can-only-be-enabled). 

# [Sales Professional](#tab/salespro)

**To enable or disable PDF generation**:

1. In the site map, under **Setup**, select **Sales settings**.

2. Under **Advanced settings**, select **PDF generation**.

3. On the **Convert to PDF** page, select the entities for which you want to enable the PDF generation capability.

    :::image type="content" source="media/convert-to-pdf-setting-enhanced.png" alt-text="Screenshot of the Convert to PDF page":::

    1. To see only the entities on which PDF generation is currently enabled, set the **Show only enabled entities** option to **Yes**.  
    2. To filter the list of entities and find a specific entity on which you want to enable PDF generation, use the **Filter by entity name** field. For example, to enable PDF generation on the Opportunity entity, enter **opp** and you'll see the entity name list filtered to show the entity names starting with *opp*.  

4. Select **Save**. PDF generation is enabled for the selected entities.

6. Review the out-of-the-box templates and create new templates as per your requirement. For more information, see [Use Word templates to create standardized documents](/power-platform/admin/using-word-templates-dynamics-365). 
    > [!NOTE]
    > You can't create a PDF file for an entity record if there's no template available for that entity.


After you enable PDF generation, sellers will be able to generate a PDF, download it to their local computer, save it to Dynamics 365 as Notes or save it to SharePoint. 

> [!IMPORTANT]
> - The **Save to SharePoint** button is available to users when SharePoint integration is enabled for your organization and the **Document management** check box is selected on the entity page. If they don't see the button, make sure that SharePoint integration and document management are enabled. For more information about the **Document Management** check box, see [Enable or disable entity options](/powerapps/maker/common-data-service/edit-entities#enable-or-disable-entity-options).
> - The **Save to Dynamics** button is available to users when **Notes** is enabled for the primary entity. If they don't see the button, make sure the **Notes (includes Attachment)** check box is selected on the entity page in the **Customization** area. By default, notes are enabled on all out-of-the-box entities. For more information about the **Notes** check box, see [Entity options that can only be enabled](/powerapps/maker/common-data-service/edit-entities#entity-options-that-can-only-be-enabled). 

## Enable or disable PDF generation if you're using the Dynamics 365 for phones mobile app

If you're using the **Dynamics 365 for phones** mobile app, you can enable the capability to create PDF files only on the following entities: Accounts, Contacts, Leads, Opportunities, Quotes, Orders, and Invoices.

1. In the site map, under **Setup**, select **Sales settings**.

2. Under **Advanced settings**, select **PDF generation**.

3. To enable or disable PDF generation, on the **Generate PDF file** page, under **Select whether PDF files can be created, saved, and emailed based on Dynamics 365 Sales entity records**, set the entity toggle to **Enabled** or **Disabled**. For example, if you want to enable PDF generation on **Opportunity** records, set the Opportunity toggle to **Enabled**. 

    ![PDF generation settings page to enable PDF generation.](media/enable-pdf-generation-sp.png "PDF generation settings page to enable PDF generation")

4. Select **Save**. 

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Create PDF files from sales records](create-quote-pdf.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

