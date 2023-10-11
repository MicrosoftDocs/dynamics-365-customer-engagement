---
title: Customization considerations for the work order form
description: Commonly mentioned considerations for customizations of the work order form in Dynamics 365 Field Service.
ms.date: 06/30/2023
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Customization considerations for the work order form

This article lists common considerations when customizing the work order form in Dynamics 365 Field Service.

## Open work order subgrids as popups

Configure work order subentities to pop out as dialog boxes and edit them without having to leave the work order form. This configuration helps dispatchers keep the work order context. Administrators can enable the **Work Order Subgrid Records Open as Popups** setting in the settings area. For more information, go to [Other settings](configure-default-settings.md#other-settings).

## Show simplified work order commands

The work order ribbon uses the simplified view by default. It shows only the most relevant commands. An administrator can disable the **Show Simplified Work Order Commands** setting to show all commands. For more information, go to [Work Order / Booking settings](configure-default-settings.md#work-order--booking-settings).

Check out the following video on simplified work order commands and more updates to work orders.

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

## Components for the new work order experience (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The new work order experience introduces several new code components for makers to use on their forms and views. The following sections list options and limitations for these code controls. For more information about working with code controls, see [Code controls in the Power Apps developer documentation](/power-apps/developer/component-framework/custom-controls-overview).

### Work order form

#### Form header and command bar

- Header: Fully customizable. Makers can change the information shown in the maker portal. They can also hide sections or tabs and create their own custom tabs.
- Form switchers: Makers can control which [forms users can see based on security roles](/power-apps/maker/model-driven-apps/control-access-forms).
- Command bar: Uses the simplified command bar by default. [Admins can turn the **Show Simplified Work Order Commands** setting off](configure-default-settings.md#work-order--booking-settings). If a custom-added command is gone, you can go to the maker portal and make it visible again

#### Work order Copilot recap

A control that summarizes work orders and associated bookings including timeline notes with the help of Copilot in Field Service.

This control works on the default and custom work order forms but it doesn't work on entities other than the work order.

Copilot currently can't summarize custom entities. It only summarizes default fields.

#### Work order status

A control to select the Work Order status and substatus.

- You can [add custom system substatuses](work-order-status-booking-status.md).
- You can use the status dropdown control on other entities, but:
  - It doesn't support icons
  - All status colors are purple

Field Service doesn't support custom system status. If you add one it doesn't have a status icon. Colors for the system status are set by the system and you can't change them.

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

The default zoom level is currently fixed and you can't change it. The functional location picker only shows the child-most entity, and does not show breadcrumbs of the higher levels such as Building > Floor > Room.

#### Contact card

A control that shows the service or billing account contact, and the reported by contact (when available).

- This control works on custom work order forms. If placed on a non-work order form, the control won’t enter edit mode.

The contact can map to the billing account contact, service account contact, reported by contact. It won't work with any other type of contacts. The lookup doesn't work when pointed to non-contact fields.

#### Asset card

A control that shows assets from the primary asset, as well as any secondary assets set via the products, services, and tasks in the work order. The control renders child nodes of an asset.

This control can be placed on custom work order forms but it doesn't work on non-work order entities

If the control is placed in a 3-column form layout, the icon to pop-up the full screen asset view doesn't load because the control adapts to narrow form factors.

#### Booking card

A control that helps service managers ensure work orders are moving along by providing recommendations on the next action. For unscheduled work orders, it provides a booking suggestion, when scheduled it shows booking details, and when completing the work order, you see a summary.

- This control doesn't work with non-work order entities.
- This control requires that the mapping of the system status, substatus, and primary resolution is configured correctly. Otherwise, the control fails to load. Specifically if the system status doesn't map to the right work order system status field.


The following components are added:

- Work order grid (*msdyn_FieldService.WorkOrderList*) with customizable columns.
- Functional location card (*msdyn_FieldService.LocationCard*) that works on the work order entity only.
- Dynamics bookings card (*msdyn_FieldService.BookingCard*) that works on the work order entity only.
- Contact card (*msdyn_FieldService.CustomerContactCard*) where you can customize the mapping of the *Reported by contact* field.
- Asset card (*msdyn_FieldService.WorkOrderAssetTree*).
- Products and services summary card (*msdyn_FieldService.LineItemsTabSummaryCard*). The mapping of fields only works for *CostNotToExceed* to *msdyn_costntepercent* and *PriceNotToExceed* to *pricentepercent*.
- Products and services line items grid (*msdyn_FieldService.LineItemsTabTable*) which you can use on custom views for products or services. To enable filtered results for products, edit the control and set the data source to *Records: Only Related Records*, *Entity: Work Order Products (Work Order)*, and *Default View: LineItemsTab Active Products*.
- Task summary card (*msdyn_FieldService.TasksAtAGlanceCard*).
- Task list (*msdyn_FieldService.TasksGrid*).
- References card (*msdyn_FieldService.ReferenceDisplay*) which can show knowledge articles, guides from tasks, or media references. The maximal size of the media files is 100 MB.

## Next steps

- [Set up booking statuses](set-up-booking-statuses.md)
- [Create a work order](create-work-order.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
