---
title: "Create and deploy Word templates (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Create Word templates that you can use to export, format, and share detailed data from single records in Dynamics 365 for Marketing"
keywords: "administration; organization settings; Word; templates; export"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 9db7c881-4ba5-4b8d-a241-1f6ff3f5de73
author: kamaybac
ms.author: kamaybac
robots: noindex,nofollow
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Manage [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] templates

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] provides powerful ways to present your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data in a standardized and well-formatted document. With [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] templates, you can easily create and share your template with others, so all the documents that go out to your customers have a consistent look that matches your organization's branding.

When the templates are ready, users can generate standardized documents that are automatically populated with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data with just one click.

## Step 1: Create a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template

1. Sign in to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] as a user with the System Administrator role.

1. Go to **Settings** > **Advanced Settings** > **Organization** > **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] & [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates** and choose **New Template**.

1. Select **[!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Template**, and then select **Next**.

    ![Choose which type of template to create](media/create-template-type.png "Choose which type of template to create")

1. Select an entity to which the template applies. The template will use data from this entity.

    ![Choose an entity for the template](media/create-template-word-entity.png "Choose an entity for the template")

1. To select the fields that you want to be included in the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template, select **Choose Related Entities**.

1. The **Choose Related Entity** dialog box opens. The relationships you select on this screen determine what entities and fields are available later when you define the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template. Only select the relationships you need to add [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data to the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template. Here are some example relationships for the account entity:

    - 1:N Relationship. An account can have multiple contacts.
    - N:1 Relationship. A lead, account, or contact can have multiple accounts.
    - N:N Relationship. An account can have multiple marketing lists. A marketing list can have multiple accounts.

    When you're done choosing relationships, select **Done**.

    > [!NOTE]
    > To ensure that documents are downloaded in a timely matter, there is an upper limit of 100 for the number of related records returned for each relationship. For example, if you're exporting a template for an account and you want to include a list of its contacts, the document will return at most 100 of the account's contacts.

1. In the **Select Entity** dialog box, select **Next**.

1. Select **Download** to create a [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] file on your local computer with the exported entity included as XML data.

1. To upload the template later, select **Upload the template later** check box, and then select **Next**.

1. To upload the template after you customize the data, go to the list of templates, and then select **Upload Template**. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Step 4: Upload the Word template back into Dynamics 365](#step-4-upload-the-word-template-back-into-dynamics-365)

## Step 2: Enable the Developer tab

Open the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template file. At this point, the document appears to be blank.

![A new Word template](media/word-blank.png "A new Word template")

To see and add [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] XML data, you need to enable the **[!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Developer** tab.

1. Go to **File** &gt; **Options** &gt; **Customize Ribbon**, and then select the **Developer** check box.

    ![The Customize Ribbon dialog in Word](media/word-custom-ribbon-ill.png "Add the Developer tab to your ribbon in Word")

1. Select **OK**.

The **Developer** tab now appears in the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] ribbon.

![The Developer tab added to the Word ribbon](media/word-developer-tab-ill.png "The Developer tab added to the Word ribbon")

## Step 3: Define the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template

Use the **XML Mapping Pane** to define the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template by using [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] entity fields.

1. In your [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template, select **Developer** &gt; **XML Mapping Pane**.

    ![The XML Mapping Pane button on the Developer tab](media/word-XML-mapping-ribbon-ill.png "The XML Mapping Pane button on the Developer tab")

    The **XML Mapping** pane opens with the default XML schema selected.

    ![The XML Mapping pane in Word](media/word-XML-mapping-pane.png "The XML Mapping pane in Word")

1. Select the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] XML schema. It will begin with "urn:microsoft-crm/document-template/".

    ![Select the Dynamics 365 XML schema](media/ill-word-d365-schema.png "Select the Dynamics 365 XML schema")

    > [!IMPORTANT]
    > If you have frequent accidental edits that cause [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] to freeze or degrade its performance, turn off the AutoCorrect options.

1. Expand the entity to see all available fields, right-click the field you want to add, and then select **Insert Content Control** &gt; **Plain Text**.

    ![Insert Content Control menu](media/ill-word-add-field.png "Select a field to add as plain text")

    The field from [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is added to the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template.

    ![A Word template with one field added](media/word-field-added.png "A Word template with one field added")

1. Add additional entity fields, add descriptive labels and text, and format the document. A completed template might look like this:

    ![An example of a completed Word template](media/word-template-example.png "An example of a completed Word template")

1. Some content control fields you entered are likely to have multiple lines of data. For example, accounts have more than one contact. To include all the data in your [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template, set the content control field to repeat as follows:

    1. Put fields with repeating data in a table row.

    1. Select the entire table row in the template.

        ![A table in Word with a full row selected](media/word-template-row.png "A table in Word with a full row selected")

    1. In the **XML Mapping** pane, right-click the relationship containing the content control fields, and then select **Repeating**.

        ![Set a field to repeating in the XML Mapping pane](media/word-template-repeating.png "Set a field to repeating in the XML Mapping pane")

    When you use the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to create a document, the table will be populated with multiple rows of data.

1. When the template has the fields and formatting you want, save it and upload it into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

<a name="step-4-upload-the-word-template-back-into-dynamics-365"></a>

## Step 4: Upload the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]

When you have your [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template built the way you want, save it so you can upload it into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

An administrator can use the **Settings** page to upload the [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] template into [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

> [!NOTE]
> Users in your organization can see the templates available to them by selecting **[!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates** on the command bar in the list of records.

1. In [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], go to **Settings** > **Advanced Settings** > **Organization** > **[!INCLUDE[pn-excel-short](../includes/pn-excel-short.md)] & [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)] Templates**.

1. Select **Upload Template**.

1. Find and upload the file.

    ![Upload Template dialog](media/excel-upload-template.png "Upload Template dialog box")

1. Select **Upload**. You'll see the summary of the file you're uploading.

1. Select **Finish**.

### See also

[Export data to Word or Excel docs](export-data-word-excel.md)  
[Business management settings](business-management-settings.md)