---
title: Create a query to view a sequence in an entity record grid
description: Create a saved query to show an in-progress sequence in an entity record grid
ms.date: 04/30/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# View a sequence in a grid

As an administrator, you can create a saved query to view the latest sequences that are in progress in an entity record grid.

## Create a saved query

1.	Make sure that you have the System Administrator security role or an equivalent role. To check your security role, complete the following steps:

    1.	Follow the steps in [View your user profile](/powerapps/user/view-your-user-profile?context=/dynamics365/context/sales-context).   
    1.	If you don't have the correct permissions, contact your system administrator.   

1.	(Optional) Create a new view for each entity that you want to include in the sequence view. You must enable the entity for the sales accelerator on the **Workspace** setup page. For more information, see [Manage access and record type](manage-access-record-type-sales-accelerator.md).  

1.	Create a solution named **SequenceViewSolution**. For more information, see [Create a solution](/powerapps/maker/canvas-apps/add-app-solution?context=/dynamics365/context/sales-context).  

1.	Select **Entities** > **Add Existing** > **Entity**, and then find and add the entities for which you created views (as described in step 2).   

1.	Select **Save and Close**.   

1.	Publish all customizations.   

1.	Select the **SequenceViewSolution** solution you created in step 4.

1.	Export the solution, and choose the **Package type** as **Unmanaged**. The `SequenceViewSolution.zip` file is downloaded.

1.	Delete the solution that you created during step 4 from the organization.

1.	Extract the exported solution zip file (the file you downloaded in step 9).

1.	In the solution contents folder, locate and then open `Solution.xml`. 

1.	Change the following value in `Solution.xml`, and then save it:  

    Change `<Managed>0</Managed>` to `<Managed>1</Managed>`.

1.	In the solution contents folder, locate and open `customization.xml`.

1.	For each view that you added in step 2, locate its `<savedquery>` and add the following to its `fetchxml` function:

    ```xml
    <link-entity name="msdyn_sequencetarget" from="msdyn_target" to="{primary key of the entity}" alias="sequencetarget" link-type="outer">
        <attribute name="msdyn_parentsequence" />
        <filter type="and">
            <condition attribute="statecode" operator="eq" value="0" />
        </filter>
    </link-entity>
    ```

    For example, if the view was added for the lead entity, replace the `to` parameter in `link-entity` with `leadid`.

1.	For each view that you added in step 2, locate its `<savedquery>` and add the following to its `layoutxml`.

    ```xml
    <cell name="sequencetarget.msdyn_parentsequence" width="100" />
    ```    

1.	Save the file.

1.	Zip the folder.

1.	Open a model-driven app, such as Sales Hub in Dynamics 365.

1.	Go to **Settings** > **Solutions**.

1.	Import the solution (the zipped file you created in step 18).

1.	Publish all customizations.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[Manage sequences](create-manage-sequences.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]

