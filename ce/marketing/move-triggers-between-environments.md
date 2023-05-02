---
title: "Move Triggers between Environments – ALM process for Triggers in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: " Learn how to Move Triggers between Environments – ALM process for Triggers in Dynamics 365 Marketing."
ms.date: 05/01/2023
ms.custom: 
  - dyn365-marketing
ms.topic: get-started
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Move Triggers between Environments – ALM process for Triggers

Customers often use multiple Dynamics 365 environments to support different stages of their application lifecycle management process. For example, they may have a development environment for creating and testing new features, a staging environment for pre-production testing, and a production environment for  final application deployment. 

Using multiple environments allows customers to maintain separate configurations, isolate changes, and avoid potential conflicts that could impact system’s stability. By doing so, they can ensure a smoother and more reliable deployment process and enhance the overall user experience.

The migration of triggers between environments is a key process that ensures customers are using the most recent and updated version of the triggers in the right places. The trigger definition is typically exported from the source to target environment during the migration process. By moving triggers between environments, customers can reduce the possibility of issues occurring while deploying to production. It also allows customers to test triggers in a development environment before moving them to production.

[Power Platform solutions](transfer-solution.md) are THE mechanism for implementing ALM by defining how code and metadata are packaged for transportation from one environment to another. Solutions include components such as entities, segments, journeys, connectors, flows, and forms but don't include customer data by default. For ALM support, Dynamics 365 features must be built as "Solution-Aware," with entities modeled as solution components, and dependencies known to Dataverse, so they can be resolved during import. Furthermore, environment-specific data, including usage data, is excluded from the solution, allowing for a more streamlined and efficient ALM process. By utilizing Solutions, Dynamics 365 customers can achieve better control over their system's configuration, reduce errors, and ensure consistency across environments, ultimately improving the user experience.

Customers can move triggers in **any** state between environments (draft or published or stopped). To do so, follow the steps highlighted below:
1. Open Power Platform Solutions for your current source environment
 
    > [!div class="mx-imgBorder"]
    > ![Screenshot of how to open a power platform](media/power-platform-opening-step.png "Screenshot of how to open a power platform")

    > [!div class="mx-imgBorder"]
    > ![Screenshot of selecting a Power App from dashboard](media/select-power-app.png "Screenshot of selecting a Power App from dashboard")

    > [!IMPORTANT]
    > Ensure that the environment for the Power Apps is the same as the one that you are currently working on (the one that has the triggers to migrate)

1. Select the ‘**Solutions**’ on the left pane and select ‘**+New Solution**’.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of selecting the solutions tab to create a new solution](media/solutions-tab.png "Screenshot of selecting the solutions tab to create a new solution")

1. Name your solution and select publisher – Make sure that the solution has a unique name that highlights the trigger or triggers that will be added.

    > [!div class="mx-imgBorder"]
    > ![Fill in the details for new solution creation](media/name-your-solution.png "Fill in the details for new solution creation")

1. Add only your ‘trigger’ records to the solution. (**Component Type: Trigger**)
    - This can be done by using the following steps:
        1. Select on ‘Add existing’ dropdown on the top pane of the page.
        1. Select on ‘More’> ’Other’>‘Triggers’.
        1. Search for the trigger using the search functionality and click ‘Add’ once you find the relevant record.

1. Adding the trigger records should add the following records to your solution as well:

    |     Trigger State    |     Components added    |
    |---|---|
    |     Draft    |     Trigger record, CustomerAPI record & CatalogAssignment record    |
    |     Published    |     Trigger record, CustomAPI record, CatalogAssignment record and customAPIrequestparameter records    |

1. Once done, you're now ready to migrate the solution to the destination environment.
1. To migrate the solution, you need to export it – To do this, follow the below steps: 

    - Select ‘Export Solution’

    > [!div class="mx-imgBorder"]
    > ![Screenshot of exporting a solution to start migration](media/export-solution.png "Screenshot of exporting a solution to start migration")

    - Ensure that the solution is exported as ‘Managed’

    > [!div class="mx-imgBorder"]
    > ![Make sure to select the recommended solution as managed solution](media/managed-solution-to-export.png "Make sure to select the recommended solution as managed solution")

    - Select ‘Export’ – depending on the number of triggers in the solution, it takes a few minutes for the Solution to be ready to download.

1. Once done, download your managed solution

1. Now, navigate to the destination environment where you want to import the Solution and the triggers.

1. Once there, use Steps 1,2 and 3 to navigate to the ‘Solutions’ page on the Power Apps portal where the solution can be imported.

1. Once done, select on ‘Import Solution’ to be able to upload the managed solution that was downloaded from the source environment.

1. Now, navigate to the target environment to check the triggers that are imported.

    - The state of the trigger is retained from the source environment - 
    draft triggers will be imported in draft state – Published triggers will be imported in published state – Stopped triggers will be imported in draft state.

## Solution Upgrade Experience 

Solution upgrades for those solutions that contain managed triggers is slightly different from the migration of solutions for the first time between environments.  Solution upgrades on triggers can vary depending on how the users work with the triggers in the destination or source environments.
Solution upgrades will only change the state of the triggers when the triggers in the destination organization are in a draft state. The table below represents how state transitions occur for solution upgrades:

|     Trigger state at   destination    |     State of trigger post solution upgrade    |
|---|---|
|     Published    |     Does not change –Trigger continues to remain in published state irrespective of the state of trigger from upgraded solution     |
|     Draft    |     State transition is allowed – The trigger’s state changes to the state of the trigger that is brought over from the source environment during solution upgrade    |
|     Stopped    |     Does not change – Trigger continues to remain in Stopped state irrespective of the state of the trigger from upgraded solution    |

## Common Questions:

1. Can I import more than one trigger per solution?

    **Yes**. You can import any number of triggers per solution. At the destination, triggers that were imported in published state will transition from ‘publishing’ state to ‘published’ state over a few minutes.

1. Do all triggers in a solution need to be in the same state when migrating?

    **No**. The user can choose which state to import triggers on. The state of the triggers are retained at the destination.

1. My trigger kicks of a Power Automate flow. Will the PA flow also be automatically added to the solution as a dependency once I add the trigger?

    **No**. This is not the case. If you have a PA flow that is started based on the trigger, then please do ensure that you are adding it to the solution along with the trigger record to ensure consistency and ease of use at the destination.

1. I want to move a custom trigger that is already integrated on my website. Are there some caveats that I need to know about?

    - Migrating custom triggers is different from other trigger migration. Custom triggers typically have a code snippet that needs to be instrumented to the website to start tracking customer action. These code snippets contain an ingestion key that is associated only with the environment where the trigger has been created. 

    - So, when customers migrate custom triggers between environments, in the ALM process using Power Platform Solutions, we do not migrate the ingestion key, but rather, use the ingestion key for the destination organization as the key for the imported trigger. 

    - This ingestion key in the destination org will be different from the one for the source environment. Hence, this necessitates the user to re-instrument the code snippet where needed once the migration of the trigger is complete.

1. I migrated a trigger to my destination organization using a managed solution. Now, I do not think this is what I need, and I want to delete it. But the delete button has been greyed out. What do I do?

    - Managed triggers cannot be deleted from the UI. The reason for this is to account for the dependencies and ensure that we do not leave back any orphan dependencies after deleting the trigger. Hence, a user who wants to delete a managed trigger can only via deleting the managed solution while all the triggers in the solution are in draft state.

    - If the solution contains other components that you do not want removed, then the managed trigger can instead be deleted via upgrade to a new solution version that does not contain the managed trigger (and its related records when the trigger was added to the solution) but still contains the other components. The trigger intended to be deleted by this upgrade must be in draft state.

1. Can I migrate a combination of triggers and Power Automate flows in the same solution?

    **Yes**. You should be able to move more than just triggers in the solution between the source and destination environments.

1. I imported many triggers in my solution in published state. In the destination environment, I can see that some of them have come through in a published state while the others are showing up in a draft state. Is this an error?

    When a set of triggers are imported in published state to the destination environment, they go through the process of publishing (a process that happens sequentially, a few triggers at a time). During that period, the triggers that are waiting in line to get published will display that they are in a ‘draft’ state for a short period of time on initial import before transitioning to ‘publishing’ state and finally ‘published/Ready to Use’ state.

    - If triggers are in a ‘draft’ state for a long period of time, then this might indicate an issue. At this time, the users can do either of two things:

        - Self-serve – One way to circumvent a potential issue where customers see that imported ‘published’ triggers are in ‘draft’ state for an extended period is to do a solution upgrade and reimport the trigger again. 
        - Reach out to your Microsoft representative – Open a support ticket with the Microsoft support team to have one of the engineers investigate this issue and provide additional mitigation solutions.
