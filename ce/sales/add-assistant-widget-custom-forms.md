---
title: "Add the assistant widget to a custom form"
description: "Display the assistant widget on your customized forms in Dynamics 365 Sales."
ms.date: 02/08/2022
ms.topic: article
author: udaykirang
ms.author: udag
---

# Add the assistant widget to custom forms

By default, the assistant widget is available only in the out-of-the-box forms&mdash;contact, opportunity, lead, account, and case. If you're using customized forms, you can display the assistant widget on custom forms.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Add the widget

>[!NOTE]
>- Adding the assistant widget is only supported in Unified Interface apps.
>- The assistant widget can't be added by using the new experience in Power Apps.

1. In Dynamics 365 Sales Hub app and go to **Advanced settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings option on the Settings menu.](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

2.  On the navigation bar, select **Settings**, and then select **Customizations**.

    > [!div class="mx-imgBorder"]
    > ![Customization option on the site map.](media/customization-in-sitemap.png "Customization option on the site map")

3.  On the **Customization** page, select **Customize the System**.

4. Under **Components**, expand *Entities*, and then the entity you want, and select **Forms**.

5. In the list of forms, select the form to which you want to add the assistant widget.

6. Go to the **Insert** tab and add a section with column to the form.

    > [!div class="mx-imgBorder"]
    > ![Add a section with column to the form.](media/customization-add-section-with-column-form.png "Add a section with column to the form")

7. Select the added section and then on the tool bar, select **Assistant**.   

    > [!div class="mx-imgBorder"]
    > ![Select assistant to add to the section.](media/customization-select-assistant-widget.png "Select assistant to add to the section")

    The assistant widget is added to the section.

    > [!div class="mx-imgBorder"]
    > ![The assistant widget is added to the section.](media/customization-assistant-widget-added.png "The assistant widget is added to the section")

    >[!NOTE]
    >- When you add the widget to the form, the assistant icon in the tool bar becomes inactive and you can't add it to the same form.
    >- When you open the form and see that the assistant icon is inactive, specifies that the assistant widget is already added to the form. 

8. Save and publish the form.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Configure the assistant](configure-assistant.md)      
[Guide customer communications with assistant](assistant.md)

