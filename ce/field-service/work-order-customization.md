---
title: Customization considerations for the work order form
description: Commonly mentioned considerations for customizations of the work order form in Dynamics 365 Field Service.
ms.date: 11/27/2023
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Customization considerations for the work order form

This article lists common considerations when customizing the work order form in Dynamics 365 Field Service.

## Open work order subgrids as popups

Configure work order subentities to pop out as dialog boxes and edit them without having to leave the work order form. This configuration helps dispatchers keep the work order context. Administrators can enable the **Work Order Subgrid Records Open as Popups** setting in the settings area. For more information, see [Other settings](configure-default-settings.md#other-settings).

## Show simplified work order commands

The work order command bar uses the simplified view by default and shows only the most relevant commands. An administrator can disable the **Show Simplified Work Order Commands** setting to show all commands. For more information, see [Work Order / Booking settings](configure-default-settings.md#work-order--booking-settings).

You can [customize the command bar](/power-apps/maker/model-driven-apps/use-command-designer) to show the commands that are relevant in your context.

## Custom work order statuses

Work order system statuses should *never* be edited because system jobs and plug-ins rely on these statuses. Instead, administrators can create custom work order substatuses that map to work order system statuses. For more information, see [Don't edit option set (choice) values](field-service-customization-best-practices.md#dont-edit-option-set-choice-values).

## Add Bing Maps to the work order form

If the Bing Maps control is manually removed from the out-of-the-box work order form, it can't be added back.

To enable Bing Maps button in form designer, at least one of the attributes of type address should have the mask *ValidForMap* added in the form.

```xml
<DisplayMask>ValidForAdvancedFind\|ValidForForm\|ValidForGrid\|ValidForMap</DisplayMask>
```

1. Create a solution on a sandbox environment that includes the form to which the Bing Maps control needs to be added. Export it as managed solution.

1. In the solution's `customizations.xml` file, go the `formxml` part of it.

1. Add the following maps control to the `<controlDescriptions>`.

```xml
        <controlDescription forControl="{8b67ae03-1701-54d2-09be-35295876ca8a}">

        <customControl id="{4273EDBD-AC1D-40d3-9FB2-095C621B552D}">

        <parameters>

        <datafieldname>msdyn\_mapcontrol</datafieldname>

        </parameters>

        </customControl>

        <customControl formFactor="0" name="MscrmControls.Map.MapControl">

        <parameters>

        <value>msdyn\_mapcontrol</value>

        <mapSourceSwitch isGroup="true" static="true">CoordinatesGroup</mapSourceSwitch>

        <latitude>msdyn\_latitude</latitude>

        <longitude>msdyn\_longitude</longitude>

        <addressEditableSwitch isGroup="true" static="true">isAddressEditableYesGroup</addressEditableSwitch>

        <outputLatitude>msdyn\_latitude</outputLatitude>

        <outputLongitude>msdyn\_longitude</outputLongitude>

        </parameters>

        </customControl>

        <customControl formFactor="1" name="MscrmControls.Map.MapControl">

        <parameters>

        <value>msdyn\_mapcontrol</value>

        <mapSourceSwitch isGroup="true" static="true">CoordinatesGroup</mapSourceSwitch>

        <latitude>msdyn\_latitude</latitude>

        <longitude>msdyn\_longitude</longitude>

        <addressEditableSwitch isGroup="true" static="true">isAddressEditableYesGroup</addressEditableSwitch>

        <outputLatitude>msdyn\_latitude</outputLatitude>

        <outputLongitude>msdyn\_longitude</outputLongitude>

        </parameters>

        </customControl>

        <customControl formFactor="2" name="MscrmControls.Map.MapControl">

        <parameters>

        <value>msdyn\_mapcontrol</value>

        <mapSourceSwitch isGroup="true" static="true">CoordinatesGroup</mapSourceSwitch>

        <latitude>msdyn\_latitude</latitude>

        <longitude>msdyn\_longitude</longitude>

        <addressEditableSwitch isGroup="true" static="true">isAddressEditableYesGroup</addressEditableSwitch>

        <outputLatitude>msdyn\_latitude</outputLatitude>

        <outputLongitude>msdyn\_longitude</outputLongitude>

        </parameters>

        </customControl>

        </controlDescription>

```

1. Search for "Bing Maps" in the same file.

1. Add the control with the following code to the row and cell wherever it needs to be added.

```xml
    <control disabled="false" id="msdyn\_mapcontrol" classid="{F9A8A302-114E-466A-B582-6771B2AE0D92}" uniqueid="{8b67ae03-1701-54d2-09be-35295876ca8a}" datafieldname="msdyn\_mapcontrol"/>
```

1. Save the file and create a new managed solution zip file out of it.

1. Import the solution to the affected environment.

> [!TIP]
> If the map control is still not visible on the form after following these steps, try removing the active form customizations.

## Components for the new work order experience

The new work order experience introduces several new code components for makers to use on their forms and views. The following sections list options and limitations for these code controls. For more information about working with code controls, see [Code controls in the Power Apps developer documentation](/power-apps/developer/component-framework/custom-controls-overview).

> [!TIP]
> Configure field level security to ensure users update only the intended fields. In some cases, for example if a field in a form is set to read-only, users might still update some fields. However, the system won't save the updated form if the user doesn't have the correct field level security.

### Work order form

#### Form header and command bar

- Header: Fully customizable. Makers can change the information shown in the maker portal. They can also hide sections or tabs and create their own custom tabs.
- Form switchers: Makers can control which [forms users can see based on security roles](/power-apps/maker/model-driven-apps/control-access-forms).
- Command bar: Uses the simplified command bar by default. [Admins can turn the **Show Simplified Work Order Commands** setting off](configure-default-settings.md#work-order--booking-settings). If a custom-added command is gone, you can go to the maker portal and make it visible again

#### Work order Copilot recap

A control that summarizes work orders and associated bookings including timeline notes with the help of Copilot in Field Service.

This control works on the default and custom work order forms but it doesn't work on entities other than the work order.

Copilot currently can't summarize custom fields. It only summarizes default fields.

#### Work order status

A control to select the Work Order status and substatus.

- You can [add custom system substatuses](work-order-status-booking-status.md).
- You can use the status dropdown control on other entities, but:
  - It doesn't support icons
  - All status colors are purple

Field Service doesn't support custom system status. If you add one, it doesn't have a status icon. You can't change colors for the system status.

#### Work order priority

A control to set the priority of a work order. It works on the work order form and on the work order grid.

- You can add custom priorities and color.
- You can use the control on work order forms but it doesn't work on entities other than the work order.

#### Timeline count

A control that shows the number notes in the timeline. Select the number to go to the timeline tab on the form.

- This control doesn't work on custom entities, even if they have the timeline control in it.
- This control supports custom work order forms.

If you place this control on the same tab as the timeline control, the count doesn't increase automatically when you add a new note. Refresh the page to see the updated number.
If activities and notes are disabled for the work order entity, the count always shows zero (which is accurate).

#### Location card

A control that shows the location of where to complete work and information about the functional location where available.

- This control works on custom work order forms but it doesn't work on entities other than the work order.

The default zoom level is currently fixed and you can't change it. The functional location picker only shows the child-most entity, and doesn't show breadcrumbs of the higher levels such as Building > Floor > Room.

#### Contact card

A control that shows the service or billing account contact, and the reported by contact (when available).

- This control works on custom work order forms. If placed on a non-work order form, the control doesn't enter edit mode.

The contact can map to the billing account contact, service account contact, reported by contact. It doesn't work with any other type of contacts. The lookup doesn't work when pointed to non-contact fields.

#### Asset card

A control that shows assets from the primary asset, and any secondary assets set via the products, services, and tasks in the work order. The control renders child nodes of an asset.

This control can be placed on custom work order forms but it doesn't work on non-work order entities.

If the control is placed in a three column form layout, the icon to open the full screen asset view doesn't load because the control adapts to narrow form factors.

#### Booking card

A control that helps service managers ensure work orders are moving along by providing recommendations on the next action. For unscheduled work orders, it provides a booking suggestion, when scheduled it shows booking details, and when completing the work order, you see a summary.

- This control doesn't work with non-work order entities.
- This control requires that the mapping of the system status, substatus, and primary resolution is configured correctly. Otherwise, the control fails to load. Specifically if the system status doesn't map to the right work order system status field.

#### Financial summary card

A control that summarizes the cost and price for a work order based on the products and services related to it.

- This control works on custom work order forms.

Make sure [cost and pricing features are enabled](configure-default-settings.md#work-order--booking-settings) to see data in this control. You can set a different NTE proximity value for this control than the one set for the work order.

#### Products and services subgrid

A control that lets you edit the products and services in a work order. Update the estimated and actual duration and quantities inline and change the status. Detailed changes to fields are possible in the side pane.

- This control works on custom work order forms. , keep the following limitations in mind.
- The control is bound to work order products. You can choose to map a second entity:
  - Work order products: Services tab is blank
  - Work order services: Product tab gets bound to work order services but the tab still references products in the interface.
- This control doesn't work on the work order entity as it has a dependency on work order product and work order services.

Custom values for products/service status aren't supported. You can't hide the product or services tab. Both tabs need an entity mapped.

#### Tasks summary card

A control that summarizes the tasks in a work order.

- This control works on custom work order forms.

- Make sure that the % completed, estimated duration, and actual duration fields included in the view used by the control.

#### Task subgrid

A control that allows you to manage tasks in a work order using inline actions to mark tasks as complete and enter inspection results. Detailed changes to fields are possible in the side pane.

- This control works on custom Work Order forms
- This control doesn't work on non-work order entities.

If the % completed field isn't visible in the view, the progress doesn't render and the action to mark as complete or incomplete doesn't work.

#### References > Knowledge article card

A control that allows you to see and link Knowledge Articles to a work order. The control also enables you to create new articles right from the work order directly.

- This control works on custom work order forms.
- It doesn't work on non-work order entities because it has a hard dependency on work order and knowledge articles.

#### References > Guides card

A control that summarizes the linked Dynamics 365 Guides to tasks in the work order. You can't preview the Guides from the web, but you can see their name and their associated Folder.

- This control can be used on custom work order forms.
- This control can’t be used on non-work order entities as because it has a hard dependency on work order service tasks and the work order entity.

#### References > Media card

A control that shows thumbnails of the media that has been attached to timeline notes.

- This control works on custom work order forms.
- This control works on custom entities as long as the entity has activities and notes enabled, and the timeline control is present.

### Work order grid

#### Grid and action bar

A control to view and select work orders. This control allows you to make inline edits to the priority and make further edits in the side pane. System status is a combined field of system status and substatus.

This control can't be applied to non-Work Order entities

Known issues and limitations:

- When applying this control to subgrids, the view selector doesn't show. Only the view selected in the Maker portal shows.
- If you customized the work order grid, the new control doesn't render due to solution layering rules. Remove such customizations first to see the control.
- The new grid experience doesn't support column filtering. Change to the **Read-Only Grid** to filter columns.
- If you remove the new grid control from the environment, you can't install it again. Contact support for help.
- The Booked Resources column (msdyn_bookingsummary) works only with the new work order experience. It's not supported on the classic grid view.

#### Context menu

An inline menu when you choose a work order to take quick actions.

- This control is available to the work order entity.
- Context menu options change depending on the status of the work order.

You can't change the items in the context menu.

#### Side pane

There are multiple forms that can be loaded inline for further edits from the work order form.

- Work order: You can edit the information it the side pane shows by modifying the *Work Order Light* form.
- Assets: You can edit the information it the side pane shows by modifying the *Customer Assets – Simple* form.

The following side panes render the same form as if you opened the full record:

- Products: *Work Order Product*
- Services: *Work Order Service*
- Tasks: *Work Order Service Task*

Only one side pane can be opened at a time. You can't change the width of the pane.

## Next steps

- [Set up booking statuses](set-up-booking-statuses.md)
- [Create a work order](create-work-order.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
