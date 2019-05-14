You can have multiple schedule board tabs, each showing different resources and requirements. Typically, these are divided by territory or lines of business.

A schedule board tab can be shared:

- publicly, available to all schedule board viewers (mostly dispatchers), 
- privately for just the person who created it
- only to specified people

By default, there exists a schedule board tab called **Initial Public View** that includes all resources and requirements. 

In this topic, we'll explore creating a new schedule board tab and sharing it with specific users.

## Prerequisites

- Field Service v6.1+
- Universal Resource Scheduling v1.0.2+

## Instructions

First, go to **Field Service > Schedule Board** and select the **+** in the top right to create a new tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of creating a new schedule board tab](../field-service/media/schedule-board-create-tab.png)


The schedule board tab settings form will appear where you can choose various configurations for the tab. 

The **Shared With** field controls who can see the tab. 

Select **Specific People**.


> [!div class="mx-imgBorder"]
> ![Screenshot of assigning a shared with option](../field-service/media/schedule-board-shared-with.png)

To assign or share the schedule board tab to specific people, you'll need to go to the record. All schedule board tabs are saved as records in the **Schedule Board Settings** entity.

Go to **Advanced Find** and look for **Schedule Board Settings**, then select Results.

> [!div class="mx-imgBorder"]
> ![Screenshot of finding schedule board settings in advanced find](../field-service/media/schedule-board-settings-advanced-find.png)


This shows all schedule board tab records and you should see the one you just created. In our example, it's "Schedule Board #3".


> [!div class="mx-imgBorder"]
> ![Screenshot of advanced find results showing all schedule board tabs](../field-service/media/schedule-board-settings-advanced-find-results.png)


Double-click the record to go to the form, and select **Share** on the top ribbon.

> [!div class="mx-imgBorder"]
> ![Screenshot of the share button for a specific schedule board setting](../field-service/media/schedule-board-share.png)


Finally, use the pop up screen to add users and teams to share the schedule board with. Any user or team added here can see the schedule board tab, given they also have access to the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of choosing users and teams to share the schedule baord with](../field-service/media/schedule-board-share-permissions.png)

## Additional notes

- Even if a schedule board tab is shared with a specific user, that user must have the minimum user permissions on the **Schedule Board Settings entity** to view it. Minimum permissions are included with the **Field Service - Administrator**, **Field Service - Dispatcher**, and **Field Service - Resource** security roles.
- We recommend giving relevant users minimum security level privileges for read, write, and create. Then use the **Shared With** option (Everyone, Specific People, Just Me) on the schedule baord tab settings to share appropriately. This is better than using the Dynamics security model, as that could lead to oversharing. 
- You can share a schedule board tab with a team for convenience. 
- To edit a schedule board, it must be shared with you and you must have write priviledges. 


