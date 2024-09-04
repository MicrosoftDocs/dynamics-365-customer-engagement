---
title: Remove LinkedIn Sales Navigator from Dynamics 365
description: If you want to uninstall LinkedIn Sales Navigator, follow these steps to delete the appropriate solutions in the correct order.
ms.date: 08/21/2024
ms.topic: article
author: udaykirang
ms.author: udag
ms.custom: 
  - dyn365-sales
---

# Uninstall LinkedIn Sales Navigator

You can uninstall LinkedIn Sales Navigator if you don't want to use it in your organization. To uninstall, you must delete the following solutions in the given order:

1. LinkedInSalesNavigatorControlsForUnifiedClient
2. LinkedIn
3. msdyn_LinkedInSalesNavigatorAnchor

**To uninstall LinkedIn Sales Navigator**

1. In your app, select **Settings** :::image type="icon" source="../sales/media/settings-icon.png" border="false":::, and then select **Advanced Settings**.  
   :::image type="content" source="../sales/media/advanced-settings-option.png" alt-text="Screenshot of Advanced Settings link in the site map.":::

2. Go to **Settings** > **Customizations** > **Solutions**.
3. On the **Solutions** page in Power Apps, select **All** and then search for the **LinkedInSalesNavigatorControlsForUnifiedClient** solution and select it.
4. Select **Show Dependencies** to check whether there are any dependencies for the solution. If dependencies exist, you must remove them before you delete the solution.  
   :::image type="content" source="media/show-dependencies.png" alt-text="Screenshot of the LinkedIn Solution and Show Dependencies option.":::
  If you see dependencies, it means that LinkedIn controls are included in Account, Contact, Lead, or Opportunity forms. 
  :::image type="content" source="media/solution-dependencies.png" alt-text="Screenshot of the dependencies for the LinkedIn solution.":::
  You must remove these dependencies before you can delete the solution.
     1. Select **Tables** from the sitemap and then select table that has the dependency.
     1. Select **Forms** and open the form that has the LinkedIn controls.
     1. Go to **LinkedIn Sales Navigator** section and remove the LinkedIn controls that are bound to form controls.  
       1. Open bound fields (Last Name, Company Name) of LinkedIn Member, Account, and InMail Profile.  
       1. On the **Field Properties** dialog box, go to the **Control** tab and remove the control binding.  
         :::image type="content" source="media/remove-linkedin-controls-field-properties.png" alt-text="Screenshot of selecting and removing the field bounds.":::  
     1. After removing the LinkedIn Member, Account, and InMail profile binding, select the **LinkedIn Sales Navigator** section, and then select **Remove**.  
         :::image type="content" source="media/remove-linkedin-controls-form.png" alt-text="Screenshot of selecting the section to remove.":::  
     1. Save and publish the form.  
     1. Repeat steps 1 through 4 for any other dependencies.
1. After you've removed all the dependencies, select **Delete**.
1. Select **OK** in the confirmation message that appears.
1. Repeat steps 3 through 6 for the **LinkedIn** and **msdyn_LinkedInSalesNavigatorAnchor** solutions.

## Related information

[Install and enable LinkedIn Sales Navigator](install-sales-navigator.md)  
[Disable LinkedIn Sales Navigator](disable-sales-navigator.md)
