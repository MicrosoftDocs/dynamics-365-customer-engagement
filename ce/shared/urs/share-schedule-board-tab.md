You can have multiple schedule board tabs configured for your business needs. As the owner of a schedule board tab, you can share the tab.

## Share a schedule board tab

Use the schedule board tab settings to share a tab.

1. On the schedule board, select the vertical ellipsis &vellip; next to a schedule board tab name and select **Board settings**.

   :::image type="content" source="../../field-service/media/schedule-board-tab-settings.png" alt-text="Screenshot of the vertical ellipsis and the settings option.":::

1. Under **Shared With** select one of the sharing options.

   - **Everyone** exposes the tab to all users who can access the schedule board.
   - **Just Me** restricts the tab to you only.
   - **Specific People** shares the tab with other users that you choose.

   :::image type="content" source="../../field-service/media/schedule-board-shared-with.png" alt-text="Screenshot of assigning a shared with option.":::

   > [!TIP]
   >  Every user with a Field Service security role gets access. Admins can also [create custom security roles](/power-platform/admin/security-roles-privileges) with the **Schedule Board Setting** privilege.
   > :::image type="content" source="../../field-service/media/schedule-board-setting-privilege.png" alt-text="Screenshot of the list of privileges with callout on the schedule board setting.":::

## Choose users to share the schedule board tab

The schedule board saves tabs as records in the *Schedule Board Settings* entity.

Go to **Advanced Find**, look for the **Schedule Board Settings** table and select **Continue**. For more information, see [Advanced find in model-driven apps](/power-apps/user/advanced-find).

<!-- advanced find doesn't work for the msdyn_scheduleboardsetting entity on my trial-->

The list of records shows all schedule board tab records you have access to.

Open the schedule board record you want to share to specific people. On the schedule board setting form, select **Share**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the share button for a specific schedule board setting.](../../field-service/media/schedule-board-share.png)

Add users or teams to share the schedule board with. They see the schedule board tab if they have access privileges to the schedule board.

> [!div class="mx-imgBorder"]
> ![Screenshot of Share Schedule Board Settings window.](../../field-service/media/schedule-board-share-permissions.png)

## Link to specific schedule board

<!--I doubt that the effort to create the link outweighs the benefit of loading a board more quickly. Just share it and point them to the name?-->

<!--Sometimes, you may need a link to a specific schedule board tab that dispatchers can use as a browser shortcut, to share with teammates and managers, and to reduce the load time by not having to load the entire board.

First get the GUID for the specific schedule board tab you want to link to.

A GUID is a 32-digit number in the format XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX and each record in Dynamics 365 has a GUID as a unique identifier, including schedule board tabs.

You can find the GUID of a schedule board tab with an advanced find of the **Schedule Board Settings** entity. Select the record that corresponds with the schedule board tab you want to share and use the **Email a link** button to get the GUID.

> [!div class="mx-imgBorder"]
> ![Screenshot highlighting the schedule board settings tab, Email a link button, and one owner entry.](../../field-service/media/scheduling-link-sb-get-link.png)

Finally, copy and paste the GUID into the template link below.
```
    https://[dynamics org name].crm.dynamics.com/webresources/msdyn_/fps/ScheduleBoard/scheduleboard.html?#tab=[32 digit GUID].
```
See the following for an example of an acceptable URL to a specific schedule board tab.
```
https://fieldservice.crm.dynamics.com/webresources/msdyn_/fps/ScheduleBoard/scheduleboard.html?#tab=AE595A88-A57C-E911-A95A-000D3A3B9A2B
```
Be sure to test the link by entering it into a browser. Note that people who follow the link will be prompted to log in to Dynamics 365 Field Service if they aren't already logged in. -->
