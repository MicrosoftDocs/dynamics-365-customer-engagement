---
title: "Troubleshooting related to the Product entity (Dynamics 365 Sales) | MicrosoftDocs"
description: "Follow the instructions in this article to troubleshoot the issues you might face while working with the Product entity in Dynamics 365 Sales."
ms.date: 03/31/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting the Product form

Follow the instructions in this article to troubleshoot the issues you might face while working with the Product entity in Dynamics 365 Sales.
<!--The following heading is suggested, same pattern as the Order entity article.-->
## Issue: Re-parenting isn't working, or the Parent field isn't visible

_Product re-parenting_ allows you to change the parent of an existing product record so the child products will inherit the appropriate product properties. More information: [Change the parent of a product](change-product-parent.md)

If you don't see the **Parent** field on the Product form, it could be because you've customized the Product Main form by using the unmanaged mode<!--Will the reader know what this means? If not, maybe you could have "unmanaged mode" link to more information.-->. In some cases, Product forms aren't merged properly and because of this, the required Parent field isn't added to the form.

To resolve this, you must add the Parent field back to the form. You can do this through customization or by using the solution import/export wizard.<!--I don't know what this is. Will the reader know?--> 

**To add the Parent field through customization**

1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

2.  On the navigation bar, select **Settings**, and then under **Customization**, select **Customizations**.

3.  Select **Customize the System**.

4. Under **Components** in Solution Explorer, expand **Entities**, and then expand the **Product** entity. 

5. Select **Forms**, and then open the **Product** form of type **Main** that's in the **Active**<!--edits assume these are all UI strings.--> state.

6. In the form editor, select the **Parent** field from the Field Explorer and drag it to the **Summary** section on the left side of the form editor.

    > [!div class="mx-imgBorder"]
    > ![Add the Parent field to the Product form](media/add-parent-field-product-form.png "Add the Parent field to the Product form")

7. Select **Save**, and then **Publish**.

**To add the Parent field through the solution import/export wizard**

In the custom solution<!--Will the reader know how to open this?-->, add the following row in the Product main form.<!--Will the reader know where to add this row?-->

 ```XML
<row>
<cell id="{faaa2942-4737-4721-9a19-7dcbf4eb2911}" showlabel="true" locklevel="0" colspan="2">
<control id="editableParentControl" classid="{270BD3DB-D9AF-4782-9025-509E298DEC0A}" datafieldname="parentproductid" disabled="false">
<parameters>
<DefaultViewId>{19d7f2e0-e427-40fb-85e8-53e7cef2b166}</DefaultViewId>
<IsInlineNewEnabled>false</IsInlineNewEnabled>
<DisableMru>true</DisableMru>
</parameters>
</control>
</cell>
</row>
```
<!--As noted in ts-order.md, you don't need general-information-type "See also" sections for troubleshooting content. Links to your other troubleshooting articles would be appropriate, though.
### See also

[Change the parent of a product](change-product-parent.md)  
-->