---
title: "Migrate sequences from one environment to another"
description: "Use the solution import functionality to migrate sequences from one environment to another to in Dynamics 365 sales."
ms.date: 05/10/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Migrate sequences from one environment to another

Use the solution import functionality to migrate sequences from one environment to another to in Dynamics 365 sales.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Migrate sequences

Organizations use staging (non-production) environments to set up and test complex steps, such as sequences, assignment rules, and segments. The staging environments are then used to test these steps to avoid any disruption in the organization’s operations, saving time and money. Also, the staging environments help in training the sellers. 
    
Administrators and sales managers can now migrate sequences along with their dependent entities from one environment to the other. To migrate sequences, complete the following steps:

1.	[Create a solution](#create-a-solution)
2.	[Add sequence to the solution](#add-sequence-to-the-solution)
3.	[Export the solution](#export-the-solution)
4.	[Import the solution package](#import-the-solution-package)

##	Create a solution

Let’s create a sequence solution with an example.

1.	Sign into [Power Apps](https://make.powerapps.com/) and from the left navigation, select **Solutions**.   

2.	Select **New solution** and then on the **New solution** pane, enter the values for the following fields:
            
    | Column | Description |
    |--------|-------------|    
    | Display name | Specify a meaningful name. Display name appears in the list of solutions and can be changed later. Example: **Sequence APAC leads** |
    | Name | Specify a unique name for the solution. This field is populated using the value you enter in the Display name field. You can edit this before you save the solution, but not after. |    
    | Publisher | Select the default publisher or create a new publisher. We recommend that you create a publisher for your organization to use consistently across your environments where you'll use the solution. Example: **CDS Default Publisher**. |
    | Version | Specify a version number for the solution.  This version number will be included in the file name when you export the solution. |    

    >[!div class="mx-imgBorder"]
    >![Enter values for the solution in the new solution pane](media/sa-sequence-migration-enter-solution-values.png "Enter values for the solution in the new solution pane")            

3.	Select **Create**.
        
    The solution is created and listed under solutions.

    >[!div class="mx-imgBorder"]
    >![The solution is created](media/sa-sequence-migration-solution-created.png "The solution is created")            
     
Now, let’s add the required sequences into the solution.       

##	Add sequence to the solution

After you create the solution, add the sequences that you want to export through the solution. 

1.	Open the solution. In this example, we’re opening the **Sequence APAC leads** solution.

    >[!div class="mx-imgBorder"]
    >![Open the solution to add sequence](media/sa-sequence-migration-open-solution.png "Open the solution to add sequence") 
 
2.	Select **Add existing** > **More** > **Others** > **Sequence**.    

    The **Add existing sequence** page opens with a list of sequences.

3.	Select and add the sequences that you want to include in this solution. In this example, we’re selecting and adding **APAC Leads**.

    >[!div class="mx-imgBorder"]
    >![Select and add sequence to the solution](media/sa-sequence-migration-select-add-sequence.png "Select and add sequence to the solution") 
     
    The sequence and its dependent components such as, sequences, email template, business process flows (BPF) record, sequence tags, and attribute are added to the solution. 

    In our example, the **New lead nurturing** sequence is added to the list because the **APAC Leads** sequence contains it as a step.

    >[!div class="mx-imgBorder"]
    >![List of added dependent components of the sequence](media/sa-sequence-migration-added-dependent-components.png "List of added dependent components of the sequence") 

    To see other dependent entities of the **APAC Leads** sequence, select **More options** > **Advanced** > **Show dependencies** and go to **Required objects** tab.  
    
    >[!NOTE]
    >If the sequence contains managed components, they will not be added to the solution. Therefore, when the solution is imported, the steps that are dependent on the missed components will show an error.

    >[!div class="mx-imgBorder"]
    >![View complete list of added components of the sequence](media/sa-sequence-migration-complete-list-dependent-components.png "View complete list of added components of the sequence") 
 
Now that you've added the sequences, export the solution.

##	Export the solution

Always export the sequence as an unmanaged solution. The unmanaged dependent components of the sequences are automatically added to the solution package; managed components aren't added. When the solution is imported, the steps that depend on the missing components will show an error. You can edit the sequences and their dependent components in the target environment after the import. 

1.	On the **Solutions** page, select the solution. In this example, let’s select **Sequence APAC leads**.

2.	From the tool bar, select **Export solution**.

    >[!div class="mx-imgBorder"]
    >![Select the export solution option](media/sa-sequence-migration-select-export-solution.png "Select the export solution option")
 
3.	On the **Before you export** pane, select **Next**.

    >[!NOTE]
    >After you’ve added the sequence and its dependent components to the solution and if you’ve made any changes that you would like to export, select **Publish**. The updates are added to the solution.

4.	On the **Export this solution** pane, enter or select from the following options, and then select **Export**:
    
    | Option | Description |
    |--------|-------------|	
    | Version number | Power Apps automatically increments your solution version while displaying the current version. You can accept the default version or enter your own. Example: **1.0.0.1** |
    | Export as | Select **Unmanaged**. More information: [Managed and unmanaged solutions](/power-platform/alm/solution-concepts-alm#managed-and-unmanaged-solutions) |

    >[!div class="mx-imgBorder"]
    >![Select required options to export solution](media/sa-sequence-migration-select-option-export-solution.png "Select required options to export solution")
 
    The export can take several minutes to complete. Once finished, the export .zip file is available in the download folder specified by your web browser. Download the zip file to your local computer. For example, **SequenceAPACleads_1_0_0_1.zip**.

Now, the solution is ready for import.

##	Import the solution package

1.	Sign into [Power Apps](https://make.powerapps.com/), and then search for and select the target environment for import.

2.	From the left navigation, select **Solutions** and then select **Import solution**.

    >[!div class="mx-imgBorder"]
    >![Select the import solution option](media/sa-sequence-migration-select-import-solution.png "Select the import solution option")
 
3.	On the **Import a solution** dialog, browse and open the solution that you've downloaded.

    >[!div class="mx-imgBorder"]
    >![Browse and select the solution](media/sa-sequence-migration-browse-select-solution.png "Browse and select the solution")
 
4.	Select **Next**.

    The solution is imported into the target environment along with its dependent components. Also, when you delete the sequence, the dependent components remain in the imported environment, in case the components are used by other sequences or entities. 

    If the import fails due to missing dependencies, a message is displayed on the top of the pane. 

    >[!div class="mx-imgBorder"]
    >![Solution import fail message](media/sa-sequence-migration-import-failed-message.png "Solution import fail message")

    >[!NOTE]
    >To troubleshoot import related issues for solutions, go to [Troubleshoot solution import errors in Microsoft Dynamics 365](/troubleshoot/dynamics-365/sales/troubleshoot-solution-import-errors-in-dynamics-365)
 
    Select **Show dependencies**. A list of dependencies that aren't available in the environment is displayed. Install the dependencies and import the solution again. 

    >[!div class="mx-imgBorder"]
    >![View missing dependencies](media/sa-sequence-migration-view-missing-dependencies.png "View missing dependencies")
    
    >[!NOTE]
    >To download and view the error log, select **Download**.
 
[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Create and activate a sequence](create-and-activate-a-sequence.md)

[Manage sequences](create-manage-sequences.md)