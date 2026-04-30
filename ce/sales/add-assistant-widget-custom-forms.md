---
title: Add the assistant widget to a custom form
description: Display the assistant widget on your customized forms in Dynamics 365 Sales.
ms.date: 04/30/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Add the assistant widget to custom forms

By default, the assistant widget is available only in the out-of-the-box forms&mdash;contact, opportunity, lead, account, and case. If you're using customized forms, you can display the assistant widget on custom forms.

## Add the widget

>[!NOTE]
>- You can only add the assistant widget in Unified Interface apps.
>- You can't add the assistant widget by using the new experience in Power Apps.

1. In the sales app, go to **Settings** > **Advanced Settings**.

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.

1. Under **Components**, expand *Entities*, and then the entity you want. Select **Forms**.

1. In the list of forms, select the form to which you want to add the assistant widget.

1. Go to the **Insert** tab and add a section with column to the form.

    :::image type="content" source="media/customization-add-section-with-column-form.png" alt-text="Screenshot of adding a section with column to the form.":::

1. Select the added section. On the toolbar, select **Assistant**.   

    :::image type="content" source="media/customization-select-assistant-widget.png" alt-text="Screenshot of selecting Assistant to add to the section.":::

    The assistant widget is added to the section.

    :::image type="content" source="media/customization-assistant-widget-added.png" alt-text="Screenshot of the assistant widget added to the section.":::

    >[!NOTE]
    >- When you add the widget to the form, the assistant icon in the toolbar becomes inactive and you can't add it to the same form.
    >- When you open the form and see that the assistant icon is inactive, it specifies that the assistant widget is already added to the form. 

1. Save and publish the form.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Configure the assistant](configure-assistant.md)      
[Guide customer communications with assistant](assistant.md)


