---
title: Customize the ZoomInfo app for Dynamics 365 Sales
description: Learn how to customize the ZoomInfo app to display in table entities and add a site map to your Dynamics 365 Sales app.
ms.date: 07/07/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Customize the ZoomInfo app

After you install the ZoomInfo app, you can use it as a standalone app. Every time sellers need to view the required information, they must return to the app selection area and choose ZoomInfo. 

As an administrator, you can customize the ZoomInfo app in the following ways:

- **Add ZoomInfo entry to the site map**: Add the ZoomInfo entry to your Dynamics 365 Sales app on the left navigation site map. Provide easy access to ZoomInfo, including the Admin Portal and ZoomInfo Knowledge Center. For more information, see [Add ZoomInfo entry to site map](#add-zoominfo-entry-to-site-map).
- **Add ZoomInfo form to table entities**: Add the ZoomInfo form to standard or custom Account, Contacts, and Leads table entities. Provide sellers with inline access to ZoomInfo data. For more information, see [Add ZoomInfo form to entities](#add-zoominfo-form-to-table-entities).

## Prerequisites

Before you start, make sure you meet the following prerequisites:

- You're assigned the system administrator role. For more information, see [Assign a security role to a user](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user).  
- The ZoomInfo app is installed on your Dynamics 365 Sales organization. For more information, see [Install ZoomInfo app](install-zoominfo-app.md).  

## Add ZoomInfo entry to site map

When you add the ZoomInfo entry to the left navigation site map of your Dynamics 365 Sales app, sales teams can perform searches, and administrators can access the Admin Portal to configure export preferences, custom mapping, and other settings. You can also add a site map entry to the ZoomInfo Knowledge Center. 

**To add the entry to the site map:**  

1.	Sign in to the [Power Apps portal](https://make.preview.powerapps.com/) and choose the organization where you installed the ZoomInfo app.
1.	On the left navigation pane, select **Apps**. You see a list of apps that are available in the environment.    
1.	Select the **Sales Hub** app, and then select **More options** (**…**) > **Edit**.   
    
    :::image type="content" source="media/zoominfo-saleshubapp-select-more-options.png" alt-text="Screenshot of selecting Edit from More options on the Sales Hub app.":::

1.	On the App Designer page, under **Site Map**, select the pencil icon.
    
    :::image type="content" source="media/zoominfo-site-map.png" alt-text="Screenshot of selecting the pencil icon to open the site map designer.":::
 
1.	Choose an existing area or add a new area to the site map. Then, from the **Components** tab, drag and drop **Group**.
    
    :::image type="content" source="media/zoominfo-sitemap-add-group-component.png" alt-text="Screenshot of dragging and dropping the group component to an area.":::
 
1.	On the **Properties** tab, under the **General** section, add the following group information:

    | Field | Description |
    |-------|-------------|
    | Title | Specifies the name of the group. Enter **ZoomInfo** as the title. |
    | ID | Specifies the unique identification number for the group. Use the default value. |

    :::image type="content" source="media/zoominfo-sitemap-enter-properties.png" alt-text="Screenshot of entering the title for the group component.":::

1.	Select the added ZoomInfo group. Then, on the right pane under the **Components** tab, drag and drop the **Subarea**.

    :::image type="content" source="media/zoominfo-sitemap-add-subgroup-component.png" alt-text="Screenshot of dragging and dropping the subarea component to the group.":::
 
1.	Select the added subarea. Then, on the right pane under the **Properties** tab, enter the following information to add the **ZoomInfo** site map entry:

    | Field | Description |
    |-------|-------------|
    | Type | Web Resource |
    | URL | ZoomInfo |
    | Title | ZoomInfo |

    :::image type="content" source="media/zoominfo-sitemap-enter-subarea-properties.png" alt-text="Screenshot of entering properties for the subarea component.":::

1.	To add a site map entry to the **ZoomInfo Knowledge Center**, repeat **steps 7 and 8**. Enter the following information for the subarea:

    | Field | Description |
    |-------|-------------|
    | Type | URL |
    | URL | ```https://university.zoominfo.com/pages/knowledge-center-zoominfo-for-sales-home``` |
    | Title | Knowledge Center |

1.	Save and publish the changes.    
1.	(Optional) To verify the successful addition of the ZoomInfo site map, open the Dynamics 365 Sales Hub app. The ZoomInfo Group you added appears in the left navigation pane.
   
    :::image type="content" source="media/zoominfo-sitemap-added.png" alt-text="Screenshot of the ZoomInfo site map added to the left navigation pane.":::

## Add ZoomInfo form to table entities

You can add the ZoomInfo form to standard or custom Account, Contacts, and Leads table entities. When you add the form, sellers can access the ZoomInfo data without moving away from records.

To add the form, follow these steps:

1.	[Create a solution](#create-a-solution)
1.	[Add solution components to table entity](#add-solution-components-to-table-entity)
1.	[Add form to table entity](#add-form-to-table-entity) 
1.	[Customize form components](#customize-form-components)

### Create a solution

Create a solution to locate and work with the components you customize. Then, apply them to the Power Platform environment that hosts your Dynamics 365 apps. This process makes it easier to return to your custom solution to make future changes.  

**To create a solution:**

1.	Sign in to the [Power Apps portal](https://make.preview.powerapps.com/) and choose the organization where you installed the ZoomInfo app.
1.	On the left navigation pane, select **Solutions**.   
1.	Select **New solution**. On the **New solution** pane, enter the information as described in the following table:    

    | Field | Description |
    |-------|-------------|
    | Display Name | The name shown in the list of solutions. You can change this later. |
    | Name | The unique name of the solution. This name is generated from the value you enter in the Display Name column. You can edit this name before you save the solution, but you can't change it once it's saved. |
    | Publisher | Select the default publisher or create a new publisher. Create a publisher for your organization to use consistently across the Power Platform environments where you use the solution. |
    | Version | Enter a number for the version of your solution. This number is only important if you export your solution, as the version number is included in the file name. |

    :::image type="content" source="media/zoominfo-solution-add-solution.png" alt-text="Screenshot of entering new solution information.":::

1.	Select **Create**.  
    
    The new solution is created and listed in the solutions.

### Add solution components to table entity

You can now add components that aren't available in the solution. In this example, you add a table component to Account, Contacts, and Leads entities.  

1.	Open the solution you created and select **Add existing** > **Table**.    

    :::image type="content" source="media/zoominfo-solution-add-table-entity.png" alt-text="Screenshot of selecting the table option.":::

1.	On the **Add existing tables** pane, add the tables **Account**, **Contacts**, and **Leads**.

    :::image type="content" source="media/zoominfo-solution-add-tables.png" alt-text="Screenshot of adding tables Account, Contacts, and Leads.":::

1.	Select **Next**.    
    
    The three tables you selected are displayed.

### Add form to table entity

After you add the Account, Contacts, and Leads table entities to the solution component, add the form component for each table entity.    
1.	Under the **Account** section, select **Select components**.

    :::image type="content" source="media/zoominfo-solution-select-component-tables.png" alt-text="Screenshot of selecting components in the Account section.":::
 
1.	On the **Account** pane, select the **Forms** tab, and then select **Account**.

    :::image type="content" source="media/zoominfo-solution-select-account-form.png" alt-text="Screenshot of selecting Account from the Forms tab.":::
 
1.	Select **Add**.   
    
    Under the **Account** section, you see the message **1 form selected**, which indicates that you added the account form to the **Account** table.   

    :::image type="content" source="media/zoominfo-solution-selected-account-form-added.png" alt-text="Screenshot of confirmation for successful addition of the Account form.":::
 
1.	Repeat **steps 1 through 3** for the **Contact** and **Lead** table entities to add the corresponding contact and lead form to each.  
  
1.	Select **Add**.

    :::image type="content" source="media/zoominfo-solution-selected-tables-added-iframe.png" alt-text="Screenshot of Account, Contacts, and Leads tables added to the ZoomInfo iframe.":::

### Customize form components

After you add the forms to the table entities, customize how the ZoomInfo inline pages display within the standard form component used with your Account, Leads, and Contacts pages. Perform the customization in classic mode.

1.	From the form page of the **Account** form, select **Switch to classic**.

    :::image type="content" source="media/zoominfo-solution-account-form-classic-mode.png" alt-text="Screenshot of opening the Account form in classic mode.":::
 
1.	Select the **Insert** tab and then select **One column**.

    :::image type="content" source="media/zoominfo-solution-select-one-column.png" alt-text="Screenshot of selecting One column from the Insert tab.":::
 
    A new column is added as a **Tab**.

    :::image type="content" source="media/zoominfo-solution-one-column-added.png" alt-text="Screenshot of the selected One column added to the form.":::
 
1.	Select the **Tab** and then select **Change Properties**. The **Tab Properties** dialog opens.

    :::image type="content" source="media/zoominfo-solution-tab-properties.png" alt-text="Screenshot of the Tab Properties dialog.":::
  
1.	Enter the values for **Name** and **Label** as **ZoomInfo**, and then select **OK**. The tab is then renamed as **ZoomInfo**.

1.	Go to the **INSERT** tab in the **ZoomInfo** tab. Select the **Section** area and then select **Web Resource**. 
    The **Add Web Resource** dialog opens.

    :::image type="content" source="media/zoominfo-solution-add-webresources.png" alt-text="Screenshot of the Add Web Resource dialog.":::
 
1.	Under the **General** tab, enter the following information:   
    -	In the **Web resource** section, search for and add the `zi_InlineIframe.html` file that is built into the ZoomInfo for Dynamics 365 app.
    -	In the **Field Name and Properties** section, enter the **Name** and **Label** as **ZoomInfo**.
    -	In the **Web Resource Properties** section, select the **Pass record object-type code and unique identifier as parameters** option. This option helps ZoomInfo with the object type passed to perform data matches.

    :::image type="content" source="media/zoominfo-solution-enter-values-general-tab.png" alt-text="Screenshot of entering values in the General tab.":::
 
1.	Under the **Formatting** tab, in the **Row Layout** section, change the **Number of Rows** value to **16** to accommodate the ZoomInfo data.  

    :::image type="content" source="media/zoominfo-solution-enter-values-format-tab.png" alt-text="Screenshot of entering values in the Format tab.":::
 
1.	Select **OK**.
1.	Save and publish the form.   
    
    The **ZoomInfo** tab is added to the **Accounts** form. To verify, go to Dynamics 365 Sales Hub app and open the standard account page for a company. The **ZoomInfo** tab is added to the account.  

    :::image type="content" source="media/zoominfo-solution-account-home-screen.png" alt-text="Screenshot of the ZoomInfo home page for an account record.":::
 
1.	Repeat **steps 1 through 9** for the **Contact** and **Leads** forms.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

## Related information

[Install ZoomInfo app](install-zoominfo-app.md)   

