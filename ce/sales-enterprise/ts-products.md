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

# Troubleshooting related to the Product entity

Follow the instructions in this article to troubleshoot the issues you might face while working with the Product entity in Dynamics 365 Sales.

## Product reparenting

Product reparenting allows you to change the parent of an existing product record, so the child products inherit the appropriate product properties. More information: [Change the parent of a product](change-product-parent.md)

**Issue:**

Reparenting isn't working or the Parent field isn't visible on the Product form. 

**Reason/workaround:**

If you don't see the Parent field on the Product form, it could be because you've customized the Product Main form through the unmanaged mode. In some cases, Product forms aren't merged properly and due to this, the required Parent field isn't added to the form.

To resolve this, you must add the Parent field back to the form. You can do this via customization or through the solution import/export wizard. 

To add the Parent field through customization:

1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

2.  On the navigation bar, select **Settings**, and then under **Customization**, select **Customizations**.

3.  Select **Customize the System**.

4. Under **Components** in the solution explorer, expand **Entities**, and then expand the **Product** entity. 

5. Select **Forms** and then open the Product form of type Main that's in the Active state.

6. In the form editor, select the 'Parent' field from the field explorer and drag it to the **Summary** section on the left side of the form editor.

    > [!div class="mx-imgBorder"]
    > ![Add the Parent field to the Product form](media/add-parent-field-product-form.png "Add the Parent field to the Product form")

7. Save and publish the customizations.

To add the Parent field through solution import/export wizard:

In the custom solution, add the following row in Product main form –
 ```
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

### See also

[Change the parent of a product](change-product-parent.md)  