---
title: "Make grids (lists) editable by using the editable grid custom control with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to use the editable grid custom control"
ms.custom: 
ms.date: 04/10/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.assetid: cefbc0c2-769b-4230-ab5a-b28a84630a42
caps.latest.revision: 8
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Make grids (lists) editable using the editable grid custom control

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Make model-driven app grids (lists) editable using the Editable Grid custom control](/powerapps/maker/model-driven-apps/make-grids-lists-editable-custom-control)

In previous releases of Dynamics 365 Customer Engagement (on-premises), users couldn't enter data directly in grids (sometimes called lists) or subgrids on forms. They had to select the record in the grid to open a form, edit the data, and then save, which required multiple steps. With editable grids, users can do rich in-line editing directly from grids and subgrids whether they're using a web app, tablet, or phone.  
  
 ![Editable grid examples](../customize/media/editable-grid-examples.png "Editable grid examples")  
  
 When editable grids are enabled through the Editable Grids custom control, users can edit most types of fields, including basic Lookup fields and option sets.  

**Editable grids support:**
  
-   In-line editing of records at the entity or subgrid level (includes custom entities)  
  
-   System views and personal views  
  
-   Web and mobile clients  
  
-   Navigation with a keyboard or mouse  
  
-   Grouping and sorting (you can group by/sort records on the client side by any column in the current view)  
  
-   Filtering  
  
-   Moving and resizing columns  
  
-   Pagination  
  
-   Saving changes from one session to another for grouping, sorting, filtering, pagination, and moving and resizing columns  
  
-   Lookup configuration  
  
-   Calculated fields and rollup fields  
  
-   Business rules (Show error message, Set field value, Set business required, Set default value, Lock, or unlock field)  
  
-   JavaScript events  
  
-   Enabling or disabling of cells based on security role  
  
-   Users can continue to use search and charts, and can access the action bar as with read-only grids  
  
## Make main grids editable  
  
1. Open solution explorer.  
  
2. In the **Entities** list, open the appropriate entity, select the **Controls** tab, and then select **Add Control**.  
  
   ![Add Editable Grids custom control](../customize/media/add-editable-grids-custom-control.png "Add Editable Grids custom control")  
  
3. In the **Add Control** dialog box, select **Editable Grid**, and then select **Add**.  
  
4. In the **Editable Grid** row that's added, select the form factor(s) you want to apply the grid to. This makes the editable grid control the default control for the selected form factor(s).  
  
   ![Editable Grid row with form factor selection](../customize/media/editable-grid-row-wit-factor-selection.png "Editable Grid row with form factor selection")    

   > [!NOTE]
   >  At runtime, users can toggle between editable grids and read-only grids.  
      
5. To add a lookup, in the **Editable Grid** option group, select **Add Lookup**, and then in the **Configure Property "Add Lookup"** dialog box:  
  
   1.  In the **Available Views** list, select the view to add the lookup to (for example, select **My Active Accounts**).  
  
   2.  In the **Available Columns** list, select the lookup column to add (for example, select **Primary Contact**).  
  
   3.  In the **Default View** list, select the data source for the lookup field.  
  
   4.  If you want to limit the records displayed, select the **Only show records where** check box, and then select your criteria from the list, and then select **OK**.  
  
   ![Add lookup in Editable Grid control](../customize/media/add-lookup-in-editable-grid-control.png "Add lookup in Editable Grid control")  
     
6. If you have a nested grid, select the pencil button for **Nested grid view**, and then select the entity and view for the nested grid. For the **Nested grid parent ID** select the relationship for the entities. For example, the ParentAccountID field connects the **Account** and **Contact** entities.  
  
   > [!NOTE]
   >  Nested grids are only available for phones, tablets, and unified interface apps. Nested grids aren't available with classic web client apps. More information: [About Unified Interface](../admin/about-unified-interface.md) 
  
7. If you don't want to allow the user to group data by any column in the view (you want to save space, for example), in the **Group by Column** row, select the pencil button, and then in the **Configure Property "Group by Column"** dialog box, select **Disabled**, and then select **OK**.  
  
   > [!TIP]
   >  This is mostly useful for subgrids on forms.  
  
8. If you want to add [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] events, select the **Events** tab, and then select the appropriate entities, fields, and events. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use editable grids (developer)](../developer/customize-dev/use-editable-grids-dynamics-365.md).  
  
   ![Add events in Editable Grid control](../customize/media/add-events-in-editable-grid-control.png "Add events in Editable Grid control")  
  
9. To save your work, select **Save** on the action bar.  
  
10. When you're ready to make changes available to your team, select **Publish** on the action bar.  
  
11. To test your changes, go to the view you specified in step 5, and then make some in-line editing changes.  
  
## Make a subgrid on a form editable

> [!NOTE] 
> - To save an editable grid change within a subgrid, the user must explicitly save before navigating out of the form.
> - If you are using legacy forms (versions prior to Dynamics CRM 2016) and enable an editable grid on a subgrid, the editable subgrid will not be rendered. System administrators can turn off legacy forms in system settings, if needed.
  
1.  Open solution explorer.  
  
2.  Open the form that contains the subgrid.  
  
3.  Select the appropriate control, and then select **Change Properties** on the ribbon.  
  
4.  In the **Set Properties** dialog box, select **Controls**, select **Add Control**, and then follow the same steps listed above.  
  
## Supported out-of-the-box entities

This table lists the standard entities and client types that are supported with editable grids.

|**Web/tablet/phone**|**Tablet/phone only**|**Web only**|
|-|-|-|
|Account<br /><br /> Appointment<br /><br /> Bookable Resource<br /><br /> Bookable Resource Booking<br /><br /> Bookable Resource Booking Header<br /><br /> Bookable Resource Category<br /><br /> Bookable Resource Category Assn<br /><br /> Bookable Resource Characteristic<br /><br /> Bookable Resource Group<br /><br /> Booking Status<br /><br /> Case<br /><br /> Category<br /><br /> Characteristic<br /><br /> Competitor<br /><br /> Contact<br /><br /> Email<br /><br /> Entitlement<br /><br /> Feedback<br /><br /> Invoice<br /><br /> Knowledge Article<br /><br /> Knowledge Article Views<br /><br /> Knowledge Base Record<br /><br /> Lead<br /><br /> Opportunity<br /><br /> Order<br /><br /> Phone Call<br /><br /> Price List<br /><br /> Product<br /><br /> Queue<br /><br /> Quote<br /><br /> Rating Model<br /><br /> Rating Value<br /><br /> SLA KPI Instance<br /><br /> Social Activity<br /><br /> Social Profile<br /><br /> Sync Error<br /><br /> Task<br /><br /> Team<br /><br /> User|Activity<br /><br /> Attachment<br /><br /> Channel Access Profile Rule Item<br /><br /> Competitor Address<br /><br /> Connection<br /><br /> Connection Role<br /><br /> Email Signature<br /><br /> Email Template<br /><br /> Expired Process<br /><br /> Invoice Product<br /><br /> Knowledge Article Incident<br /><br /> Lead To Opportunity Sales<br /><br /> Process<br /><br /> Mailbox<br /><br /> New Process<br /><br /> Note<br /><br /> Opportunity Product<br /><br /> Opportunity Sales Process<br /><br /> Order Product<br /><br /> Organization<br /><br /> Phone to Case Process<br /><br /> Price List Item<br /><br /> Queue Item<br /><br /> Quote Product<br /><br /> Sharepoint Document<br /><br /> Translation Process|Campaign<br /><br /> Campaign Activity<br /><br /> Campaign Response<br /><br /> Channel Access Profile<br /><br /> Channel Access Profile Rule<br /><br /> Contract<br /><br /> Entitlement Template<br /><br /> External Party<br /><br /> Marketing List<br /><br /> Position<br /><br /> Quick Campaign<br /><br /> Recurring Appointment<br /><br /> Sales Literature<br /><br /> SLA|  
 
##  Data types that aren't editable in an editable grid
The following data types aren't editable in editable grids: Customer and Partylist Lookup fields; Composite (address) fields; State/Status fields; Lookup entity-related fields (for example, the Account entity includes a contact lookup, where the Contact field is editable but the EmailAdress(Contact) field is not editable).  

## Group by views work on client side only
Grouping behavior works only on the client side and does not span pages. Group by is a client only function and works only on one page of data. Group by does not show you all options based on your complete data set on the platform. Group by shows grouping only on the current page. You can disable the grouping by using the property on custom control configuration. More information: [Make main grids editable](#make-main-grids-editable)

## Business rules work only if conditional field is a column on the grid

Business Rules on an editable grid are supported only if the conditional field is also a column on the grid. If the field is not a column the business rules won’t work. Verify that each field referenced in the business rule is also included on the form. Note that business rules on an editable grid do not fire if the editable grid is configured on a dashboard page.

## Keyboard support and shortcuts for editable grids

Editable grids are fully accessible, and provides excellent keyboard support including several keyboard shortcuts for improved productivity. The list of available shortcuts can be found here: [Use keyboard shortcuts in editable grids](../basics/keyboard-shortcuts.md#editable-grids-views)

## Frequently asked questions (FAQs)

Below are some of the most fequently asked questions related to editable grids.

### I want to configure my look-up column to a certain view, but I don't see it in the **Available Columns** dropdown in the configuration?

Ensure that the look-up column that you want to configure is not a "Regarding" column. This is a special column type and it doesn't have support for configuring the view definitions on the Editable Grid configuration dialog. 

### Why isn't my business rule working for my column?

Ensure that the column where the business rule is applied is a part of your current view. A business rule doen't pull all the fields for an entity, only those fields which are present in the current view. So, if your business rule is on a column which is not available, it won't run. <!-- Hiding this because it isn't clear what the intent is. Also note that no business rules will run in this case and not just the business rule that was applied on one column. -->

### Why is my grid read only when I have configured it to be editable?

Ensure that you are not using legacy Form rendering. Editable grids are not supported on legacy forms.

### Why can't I use editable grids on phones?

Based on customer feedback, we have removed the editable grid experience from phones. When using a editable grid on a phone, you will see a read-only version of the list control.  

### Why can't I use record navigation in a form when coming from an editable grid?

This functionality isn't available with the web client. However, this functionality is available in Unified Interface. 


### See also  
 [Use keyboard shortcuts in editable grids](../basics/keyboard-shortcuts.md#editable-grids-views)<br/>
  [Use editable grids (developer)](../developer/customize-dev/use-editable-grids-dynamics-365.md)<br/>
 [Create and edit views](../customize/create-edit-views.md)<br/>
 [Create a business rule or business recommendation](../customize/create-business-rules-recommendations-apply-logic-form.md)<br/> 
 [Customize Dynamics 365 for phones and tablets](../customize/customize-phones-tablets.md)<br/>



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]