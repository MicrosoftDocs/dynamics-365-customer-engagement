---
title: "Customize the ZoomInfo app (Dynamics 365 Sales) | MicrosoftDocs"
description: "Match the fields between Dynamics 365 and ZoomInfo to avoid mismatches between data while exporting data."
ms.date: 07/05/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Customize the ZoomInfo app    
After you install the ZoomInfo app, it is available as a standalone app and every time sellers must come back to the app selection area and choose the ZoomInfo app to view the required information.   
As an administrator, you can customize the ZoomInfo app in the following ways:   
-	**Add ZoomInfo entry to site map**: You can add the ZoomInfo entry to your Dynamics 365 Sales environment on the left navigation site map and providing easy access to ZoomInfo - including Admin Portal and the ZoomInfo Knowledge Center. More information: [Add ZoomInfo entry to site map](#add-zoominfo-entry-to-site-map).
-	**Add ZoomInfo form to table entities**: You can add the ZoomInfo form to your standard or custom Account, Contacts, and Leads table entities to provide sellers with inline access to ZoomInfo data. More information: [Add ZoomInfo form to entities](#add-zoominfo-form-to-table-entities).

## Prerequisites
Before you start, be sure you have met the following prerequisites:
-	You must have the system administrator role. More information: [Assign a security role to a user](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user).   
-	The ZoomInfo app is installed on your Dynamics 365 Sales organization. More information: [Install ZoomInfo app](install-zoominfo-app.md).   

## Add ZoomInfo entry to site map
You can add the ZoomInfo entry to your left navigation site map to your Dynamics 365 Sales app lets ales teams can perform searches and administrators can access the Admin Portal to configure export preferences, custom mapping, and other settings. Also, you can add site map entry to ZoomInfo knowledge center.   

**To add the entry to site map**  

1.	Sign in to the [Power Apps portal](https://make.preview.powerapps.com/) and choose your organization in which you’ve installed the ZoomInfo app.
2.	On the left navigation pane, select **Apps**.   
    A list of apps that are available in the environment is displayed.    
3.	Select the **Sales Hub** app and then select **More options** (**…**) > **Edit**.   
    
    > [!div class="mx-imgBorder"]
    > ![Select edit from more options on sales hub app](media/zoominfo-saleshubapp-select-more-options.png "Select edit from more options on sales hub app")

4.	In the app designer page, under site map section, select the pencil icon to open the site map designer.
    
    > [!div class="mx-imgBorder"]
    > ![](media/ "")
 
5.	Choose an existing area or add new area to the site map and then from the **Component** tab, drag and drop **Group**.
    
    > [!div class="mx-imgBorder"]
    > ![](media/ "")
 
6.	On the **Properties** tab, under the **General** section, add the following group information:

    | Field | Description |
    |-------|-------------|
    | Title | Specifies the name of the group. Enter **ZoomInfo** as the title. |
    | ID | Specifies the unique identification number for the group. Use the default value. |

    > [!div class="mx-imgBorder"]
    > ![](media/ "")

7.	Select the added ZoomInfo group and then on the right pane, under the **Components** tab, drag and drop the **Subarea**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")
 
8.	Select the added subarea and then on the right pane, under the **Properties** tab, enter the following information to add **ZoomInfo** site map entry:

    | Field | Description |
    |-------|-------------|
    | Type | Web Resource |
    | URL | ZoomInfo |
    | Title | ZoomInfo |

    > [!div class="mx-imgBorder"]
    > ![](media/ "")

9.	Similarly, repeat the **steps 7-8** for **ZoomInfo Knowledge Center** and enter the following information:

    | Field | Description |
    |-------|-------------|
    | Type | URL |
    | URL | ```https://university.zoominfo.com/pages/knowledge-center-zoominfo-for-sales-home``` |
    | Title | Knowledge Center |

    > [!div class="mx-imgBorder"]
    > ![](media/ "")

10.	Save and publish the changes.    
11.	(Optional) To verify the successful addition of ZoomInfo site map, open the Dynamics 365 Sales Hub app and the ZoomInfo Group you added is shown in the left navigation pane.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   

## Add ZoomInfo form to table entities    
You can add the ZoomInfo form to standard or custom Account, Contacts, and Leads table entities to help sellers to access the ZoomInfo data without moving away from records.
As an administrator, to add the ZoomInfo form to standard or custom Account, Contacts, and Leads table entities, follow the sequence of steps as mentioned:
1.	[Create a solution](#create-a-solution)
2.	[Add solution components to table entity](#add-solution-components-to-table-entity)
3.	[Add form to table entity](#add-form-to-table-entity) 
4.	[Customize form components](#customize-form-components)

### Create a solution   
Create a Solution to locate and work with the components you’ve customized and then apply them to your Dynamics 365 environment. This makes it easier to return to your custom solution to make future changes.   
**Follow these steps:**    
1.	Sign in to the [Power Apps portal](https://make.preview.powerapps.com/) and choose your organization in which you’ve installed the ZoomInfo app.
2.	On the left navigation pane, select **Solutions**.   
3.	Select **+ New solution** and on the **New solution** pane, enter the information as described in the following table:    

    | Field | Description |
    |-------|-------------|
    | Display Name | The name shown in the list of solutions. You can change this later. |
    | Name | The unique name of the solution. This is generated using the value you enter in the Display Name column. You can edit this before you save the solution, but after you save the solution, you can’t change it. |
    | Publisher | You can select the default publisher or create a new publisher. We recommend that you create a publisher for your organization to use consistently across your environments where you will use the solution. See Solution publisher later in this article. |
    | Version | Enter a number for the version of your solution. This is only important if you export your solution. The version number will be included in the file name when you export the solution. |

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   

4.	Select **Create**.  
    The new solution is created and listed in the solutions. Now, you can add the components to the solution.

### Add solution components to table entity    
You can add the components that aren’t available in the solution. In this example, we are adding a table component to Account, Contacts, and Leads entities.   
1.	Open the solution you have created and select **Add existing** > **Table**.    

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   

2.	On the **Add existing table** pane, add the tables **Account**, **Contacts**, and **Leads**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   

3.	Select **Next**.    
    The three tables you selected are displayed. Now, you can add form component to each selected table entity.

### Add form to table entity   
Now that you have added table entities to the solution component, add the form component for Account, Contacts, and Leads table entity.    
1.	Under the **Account** section, select **Select components**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
2.	On the **Accounts** pane, select the **Forms** tab and then select **Account**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
3.	Select **Add**.   
    Under the **Account** section, you can view the message **1 form selected** indicating that you've added the account form to the **Account** table.   

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
4.	Repeat the steps 1 to 3 for the **Contact** and **Lead** table entities to add the corresponding contact and lead form to each.    
5.	Select **Add**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
    The forms are added to the table entities. Now, you can customize the form components on how the ZoomInfo inline pages should display.

### Customize form components   
Now that you have added the forms to the table entities, customize how the ZoomInfo inline pages will display within the standard form component used with your Account, Leads, and Contact pages. Perform the customization in classic mode.
1.	From the form page of the **Account** form, click **Switch to classic**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
2.	Select the **Insert** tab and then select **One column**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
    A new column is added as a **Tab**.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
3.	Select the **Tab** and then select **Change Properties**.   
    The **Tab Properties** dialog opens.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
  
4.	Enter the values for **Name** and **Label** as **ZoomInfo**, and then select **OK**.   
    The tab is renamed as **ZoomInfo**.
5.	Go to the **INSERT** tab, in the **ZoomInfo** tab, select the **Section** area and then select **Web Resource**. 
    The **Web Resource** dialog opens.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
6.	Under the **General** tab, enter the following information:   
    -	In the Web resource section, search and add the zi_InlineIframe.html file that is built into the ZoomInfo for Dynamics 365 app.
    -	In the Field Name and Properties section, Enter the Name and Label as ZoomInfo.
    -	In the Web Resource Properties section, check to select the Pass record object-type code and unique identifier as parameters option. This option helps ZoomInfo with the object type passed to perform data matches.

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
7.	Under the **Formatting** tab, in the **Row Layout** section, change the **Number of Rows** value to **16** to accommodate the ZoomInfo data.  

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
8.	Select **OK**.
9.	Save and publish the form.   
    The **ZoomInfo** tab is added to the **Accounts** form.  
    To verify, go to Dynamics 365 Sales Hub app, and open the standard account page for a company. The **ZoomInfo** tab is added to the account.  

    > [!div class="mx-imgBorder"]
    > ![](media/ "")   
 
10.	Repeat the **steps 1 to 9** for the **Contact** and **Leads** forms.

### See also

[Install ZoomInfo app](install-zoominfo-app.md)   

[!INCLUDE[footer-include](../includes/footer-banner.md)]
