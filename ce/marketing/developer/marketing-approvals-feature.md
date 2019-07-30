---
title: "Marketing Approvals feature(Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Sample approvals feature which utilizes Dynamics 365 for Marketing extensibility endpoints"
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: cfaee020-a29d-4297-8f73-e8fb378843dc
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Approvals

Dynamics 365 for Marketing released new extensibility features to extend entities covered by a lifecycle to give users the possibility to override or use the default logic. Following are some of the functions:

- **MsDynCrmMkt.ExtensibilityCallback.liveEditablePreAction**: this function is used to introduce the code that executes before an entity enters the **live editable** state.
- **MsDynCrmMkt.ExtensibilityCallback.customUpdateFormControls**: this function is triggered when the main form of the entity executes. This gives the possibility to unlock all the controls of the page and make them editable.
- **MsDynCrmMkt.ExtensibilityCallback.canGoLive**: this function gives the ability to completely override the logic to show or hide the **Go live** ribbon.
- **MsDynCrmMkt.ExtensibilityCallback.preventSave**: this function allows to control the save behavior of the entity.
- **MsDynCrmMkt.ExtensibilitySupplier.entityValidator**: this function is returning a validator factory. Once correctly initialized can be used to verify that the configuration of the specific entity is valid. 

Another flexibility introduced for entities with complex lifecycle stage (marketing email, customer journey, content settings, marketing page, marketing form, and segment) is the possibility to configure the lifecycle of an entity. The user can add new states and can change the flow for existing entities. The only limitations are: 

1. New states between transient state (going live and stopping) and fix stage is ignored.
2. If you try to enter directly to live stage without passing through going live, you have to make sure that the entity value are not changed (otherwise what you will see in the UI it will be different of what is running in in the backend).
3. Don't remove any of the existing states. This approach should be adopt for any customizations.
4. Once an entity enters into an inactive state, it cannot be activated.

## Sample approvals

This sample shows how to implement the above mentioned functions by implementing a simple approval scenario for the customer journey. This sample approval example covers the following scenario where a user creates a customer journey record (i.e., in Draft state) and asks for the approval from the manager to publish the record. The manager rejects the approval request and asks for some changes. In this case, the entity goes back to the **Draft** state, and the changes made by the users are kept. 

The user can continue to work on this entity to implement the requested changes and submits a new approval request. This time manager accepts the approval request, and the customer journey record is pushed to **Live** state. 

## Implementation

### Step 1: Create a new solution

- Create a new [solution](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/create-solution) and name it as **Sample Approval**.
- Add customer journey entity to the solution.
- Add the following new states to the **Statuscode** attribute:
   - Approved
   - Need approval
- Navigate to **Customizations** > **Entities** > **Customer Journey** > **Fields**  and select **Statuscode** attribute. 
- Click on **Edit Status Reason Transitions**  and click on **...** next to the options available and add the status reasons as shown below and click **Ok**.

  ![Status Reason Transition](../media/marketing-status-reason-transition.png "Status Reason Transition")

- Create a new field **msdyncrm_restorestatuscode** of data type **Integer** , which is used to store the previous state information.

### Step2: Create a Web resource

Create a JavaScript web resource and add the following code. More information: [Create a Web resource](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/create-edit-web-resources)

```JavaScript
"use strict";
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constant;
(function (Constant) {
	var Constants;
	(function (Constants) {
		Constants.statusCode = "statuscode";
		Constants.requiredConsent = "msgdpr_requiredconsent";
		Constants.restoreStatusCode = "msdyncrm_restorestatuscode";
		Constants.marketingForm = "msdyncrm_marketingform";
	})(Constants = Constant.Constants || (Constant.Constants = {}));
})(Constant = MsDynCrmApprovals.Constant || (MsDynCrmApprovals.Constant = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constant;
(function (Constant) {
	/**
	* Class for manage status code for default synchronous entities in entity lifecycle
	*/
	var DefaultSyncStatusCode = /** @class */ (function () {
		function DefaultSyncStatusCode() {
		}
		DefaultSyncStatusCode.prototype.getDraft = function () {
			return 192350000;
		};
		DefaultSyncStatusCode.prototype.getLive = function () {
			return 192350001;
		};
		DefaultSyncStatusCode.prototype.getStopped = function () {
			return 192350002;
		};
		DefaultSyncStatusCode.prototype.getLiveEditable = function () {
			return 192350003;
		};
		DefaultSyncStatusCode.prototype.getExpired = function () {
			return 192350004;
		};
		DefaultSyncStatusCode.prototype.getError = function () {
			return 192350005;
		};
		DefaultSyncStatusCode.prototype.getGoingLive = function () {
			return 192350001;
		};
		DefaultSyncStatusCode.prototype.getStopping = function () {
			return 192350002;
		};
		DefaultSyncStatusCode.prototype.getNeedApproval = function () {
			return 812250000;
		};
		DefaultSyncStatusCode.prototype.getApproved = function () {
			return 812250001;
		};
		return DefaultSyncStatusCode;
	}());
	Constant.DefaultSyncStatusCode = DefaultSyncStatusCode;
})(Constant = MsDynCrmApprovals.Constant || (MsDynCrmApprovals.Constant = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constant;
(function (Constant) {
	/**
	* Class for manage marketing form status code
	*/
	var MarketingFormStatusCode = /** @class */ (function () {
		function MarketingFormStatusCode() {
		}
		MarketingFormStatusCode.prototype.getDraft = function () {
			return 192350000;
		};
		MarketingFormStatusCode.prototype.getLive = function () {
			return 1;
		};
		MarketingFormStatusCode.prototype.getStopped = function () {
			return 2;
		};
		MarketingFormStatusCode.prototype.getLiveEditable = function () {
			return 192350003;
		};
		MarketingFormStatusCode.prototype.getExpired = function () {
			return 192350004;
		};
		MarketingFormStatusCode.prototype.getError = function () {
			return 192350005;
		};
		MarketingFormStatusCode.prototype.getGoingLive = function () {
			return 1;
		};
		MarketingFormStatusCode.prototype.getStopping = function () {
			return 2;
		};
		MarketingFormStatusCode.prototype.getNeedApproval = function () {
			return 812250000;
		};
		MarketingFormStatusCode.prototype.getApproved = function () {
			return 812250001;
		};
		return MarketingFormStatusCode;
	}());
	Constant.MarketingFormStatusCode = MarketingFormStatusCode;
})(Constant = MsDynCrmApprovals.Constant || (MsDynCrmApprovals.Constant = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constant;
(function (Constant) {
	var Table;
	(function (Table) {
		Table.privilege = "privilege";
		Table.roleprivilegesCollection = "roleprivileges";
	})(Table = Constant.Table || (Constant.Table = {}));
})(Constant = MsDynCrmApprovals.Constant || (MsDynCrmApprovals.Constant = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constant;
(function (Constant) {
	var CustomerJourney;
	(function (CustomerJourney) {
		CustomerJourney.entityName = "msdyncrm_customerjourney";
		CustomerJourney.customerJourneyId = "msdyncrm_customerjourneyid";
		CustomerJourney.name = "msdyncrm_name";
		CustomerJourney.startDateTime = "msdyncrm_startdatetime";
		CustomerJourney.endDateTime = "msdyncrm_enddatetime";
		CustomerJourney.workflowDefinition = "msdyncrm_workflowdefinition";
		CustomerJourney.isRecurring = "msdyncrm_isrecurring";
		CustomerJourney.recurrenceIntervalDays = "msdyncrm_recurrenceintervaldays";
		CustomerJourney.recurrenceCount = "msdyncrm_recurrencecount";
		CustomerJourney.entityTarget = "msdyncrm_entitytarget";
		CustomerJourney.validationResults = "msdyncrm_validationresults";
		CustomerJourney.contentSettingsId = "msdyncrm_contentsettingsid";
		CustomerJourney.suppressionSegmentId = "msdyncrm_suppressionsegmentid";
		CustomerJourney.customerJourneyTimeZone = "msdyncrm_customerjourneytimezone";
		CustomerJourney.customerJourneyTemplate = "msdyncrm_customerjourneytemplate";
		CustomerJourney.customerJourneyDesignerState = "msdyncrm_customerjourneydesignerstate";
		CustomerJourney.description = "msdyncrm_description";
		CustomerJourney.purpose = "msdyncrm_purpose";
		CustomerJourney.type = "msdyncrm_type";
		CustomerJourney.requiredConsent = "msgdpr_requiredconsent";
	})(CustomerJourney = Constant.CustomerJourney || (Constant.CustomerJourney = {}));
})(Constant = MsDynCrmApprovals.Constant || (MsDynCrmApprovals.Constant = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constant;
(function (Constant) {
	/**
	* Class for manage status code for default transient entities in entity lifecycle
	*/
	var DefaultTransientStatusCode = /** @class */ (function () {
		function DefaultTransientStatusCode() {
		}
		DefaultTransientStatusCode.prototype.getDraft = function () {
			return 192350000;
		};
		DefaultTransientStatusCode.prototype.getLive = function () {
			return 192350001;
		};
		DefaultTransientStatusCode.prototype.getStopped = function () {
			return 192350002;
		};
		DefaultTransientStatusCode.prototype.getLiveEditable = function () {
			return 192350003;
		};
		DefaultTransientStatusCode.prototype.getExpired = function () {
			return 192350004;
		};
		DefaultTransientStatusCode.prototype.getError = function () {
			return 192350005;
		};
		DefaultTransientStatusCode.prototype.getGoingLive = function () {
			return 192350006;
		};
		DefaultTransientStatusCode.prototype.getStopping = function () {
			return 192350007;
		};
		DefaultTransientStatusCode.prototype.getNeedApproval = function () {
			return 812250000;
		};
		DefaultTransientStatusCode.prototype.getApproved = function () {
			return 812250001;
		};
		return DefaultTransientStatusCode;
	}());
	Constant.DefaultTransientStatusCode = DefaultTransientStatusCode;
})(Constant = MsDynCrmApprovals.Constant || (MsDynCrmApprovals.Constant = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var CustomerJourneyCustomFormFieldsController = /** @class */ (function () {
	function CustomerJourneyCustomFormFieldsController(xrm) {
		this.xrm = xrm;
		this.customFormFieldsControllerUtil = new MsDynCrmApprovals.Utilities.CustomFormFieldsControllerUtil(xrm);
	}
	CustomerJourneyCustomFormFieldsController.prototype.updateControls = function () {
		var previousStatusCode = this.xrm.Page.data.entity.attributes.get(MsDynCrmApprovals.Constant.Constants.restoreStatusCode);
		var actualStatusCode = this.xrm.Page.data.entity.attributes.get(MsDynCrmApprovals.Constant.Constants.statusCode);
		var statusCodeProvider = new MsDynCrmApprovals.Constant.DefaultTransientStatusCode();
		if (actualStatusCode.getValue() !== statusCodeProvider.getNeedApproval() &&
			actualStatusCode.getValue() !== statusCodeProvider.getApproved()) {
			return;
		}
		var enabled = previousStatusCode !== null &&
			previousStatusCode.getValue() !== null &&
			(previousStatusCode.getValue() === statusCodeProvider.getStopped() ||
				previousStatusCode.getValue() === statusCodeProvider.getLiveEditable() ||
				previousStatusCode.getValue() === statusCodeProvider.getError());
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.name, false);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.startDateTime, enabled);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.endDateTime, false);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.workflowDefinition, false);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.isRecurring, enabled);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.recurrenceIntervalDays, false);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.recurrenceCount, false);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.entityTarget, enabled);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.contentSettingsId, enabled);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.suppressionSegmentId, enabled);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.customerJourneyTimeZone, enabled);
		this.customFormFieldsControllerUtil.setFieldDisabled(MsDynCrmApprovals.Constant.CustomerJourney.customerJourneyTemplate, false);
	};
	return CustomerJourneyCustomFormFieldsController;
}());
MsDynCrmApprovals.CustomerJourneyCustomFormFieldsController = CustomerJourneyCustomFormFieldsController;
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Utilities;
(function (Utilities) {
	/**
	* Custom form fields controller factory
	*/
	var CustomFormFieldsControllerFactory = /** @class */ (function () {
		function CustomFormFieldsControllerFactory(xrm) {
			this.xrm = xrm;
		}
		CustomFormFieldsControllerFactory.prototype.create = function (entityName) {
			if (entityName === MsDynCrmApprovals.Constant.CustomerJourney.entityName) {
				return new MsDynCrmApprovals.CustomerJourneyCustomFormFieldsController(MsDynCrmApprovals.xrm);
			}
			return new MsDynCrmApprovals.EmptyCustomFormFieldsController(MsDynCrmApprovals.xrm);
		};
		return CustomFormFieldsControllerFactory;
	}());
	Utilities.CustomFormFieldsControllerFactory = CustomFormFieldsControllerFactory;
})(Utilities = MsDynCrmApprovals.Utilities || (MsDynCrmApprovals.Utilities = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Utilities;
(function (Utilities) {
	/**
	* Custom form fields controller utility
	*/
	var CustomFormFieldsControllerUtil = /** @class */ (function () {
		function CustomFormFieldsControllerUtil(xrm) {
			this.xrm = xrm;
		}
		// this function disable/enable all the fields in the form that are matching the name
		CustomFormFieldsControllerUtil.prototype.setFieldDisabled = function (fieldName, disabled) {
			var field = this.xrm.Page.data.entity.attributes.get(fieldName);
			if (field && field.controls && typeof field.controls.forEach === "function") {
				field.controls.forEach(function (control) {
					control.setDisabled(disabled);
				});
			}
		};
		return CustomFormFieldsControllerUtil;
	}());
	Utilities.CustomFormFieldsControllerUtil = CustomFormFieldsControllerUtil;
})(Utilities = MsDynCrmApprovals.Utilities || (MsDynCrmApprovals.Utilities = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var EmptyCustomFormFieldsController = /** @class */ (function () {
	function EmptyCustomFormFieldsController(xrm) {
		this.xrm = xrm;
		this.customFormFieldsControllerUtil = new MsDynCrmApprovals.Utilities.CustomFormFieldsControllerUtil(xrm);
	}
	EmptyCustomFormFieldsController.prototype.updateControls = function () {
	};
	return EmptyCustomFormFieldsController;
}());
MsDynCrmApprovals.EmptyCustomFormFieldsController = EmptyCustomFormFieldsController;
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Constants = MsDynCrmApprovals.Constant.Constants;
MsDynCrmApprovals.inheritedJQuery = window["jQuery"] || window.parent["jQuery"];
MsDynCrmApprovals.xrm = window.Xrm;
MsDynCrmApprovals.Handlers = {
	// this function is execute when an approver reject an entity
	restoreStatusCode: function (context) {
		// popup to ask to the user to confirm the action 
		var confirmDialogStrings = {
			text: "Are you sure you want to reject this approval request?",
			confirmButtonLabel: "Reject"
		};
		var confirmationDialog = MsDynCrmApprovals.xrm.Navigation.openConfirmDialog(confirmDialogStrings);
		confirmationDialog.then(function (result) {
			if (result.confirmed) {
				// if the user confirm that he want to reject the changes
				// the statuscode of the entity must be set with the value saved in msdyncrm_restorestatuscode field
				MsDynCrmApprovals.Handlers.setStatus(context, Constants.restoreStatusCode, Constants.statusCode);
				// context.data.save() is throwing exception. This is not happenning with setTimeout
				setTimeout(function () { return context.data.save(); }, 0);
			}
		});
	},
	// this function is execute when a marketer ask for approval
	askApprovals: function (context) {
		var localizationProvider = new MsDynCrmApprovals.Utilities.LocalizationProxy(MsDynCrmApprovals.inheritedJQuery);
		var localizationProviderValidationPromise = localizationProvider.getLocalizationProvider("DynamicsMarketing.labels");
		var entityName = context.data.entity.getEntityName();
		// popup to ask to the marketer if he is ready to ask for approvals
		MsDynCrmApprovals.inheritedJQuery.when(localizationProviderValidationPromise)
			.done(function (localizationProviderValidation) {
			var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(entityName);
			var confirmDialogStrings = {
				text: "Are  you ready to submit this item for approval?",
				confirmButtonLabel: "Ask approval"
			};
			var confirmationDialog = MsDynCrmApprovals.xrm.Navigation.openConfirmDialog(confirmDialogStrings);
			confirmationDialog.then(function (result) {
				if (result.confirmed) {
					// if the marketer confirm that he is ready to ask for approvals
					// the entity must be validated to check that it is ready to go live without other changes
					var entityValidatorFactory = MsDynCrmMkt.ExtensibilitySupplier.entityValidator();
					var entityValidator = entityValidatorFactory.create(localizationProviderValidation, entityName);
					// validate take as parameters 3 lamda fucntions for handle success, warning and error result
					entityValidator.validate(function () {
						//if the entity is valid we need:
						// 1. set the previous statuscode in msdyncrm_restorestatuscode field
						// 2. set status code in "needs approval" stage
						var status = context.getAttribute(Constants.statusCode);
						if (status != null && status.getValue() !== statusCodeFactory.getNeedApproval()) {
							if (status.getValue() === statusCodeFactory.getError()) {
								var restoreStatusCode = context.getAttribute(Constants.restoreStatusCode);
								restoreStatusCode.setValue(statusCodeFactory.getStopping());
							}
							else if (status.getValue() !== statusCodeFactory.getLiveEditable()) {
								MsDynCrmApprovals.Handlers.setStatus(context, Constants.statusCode, Constants.restoreStatusCode);
							}
							status.setValue(statusCodeFactory.getNeedApproval());
						}
						context.data.save().then(function () { context.ui.refreshRibbon(); }, function () { context.ui.refreshRibbon(); });
					}, function () { context.data.refresh(); }, function () { context.data.refresh(); });
				}
			});
		});
	},
	// this function is execute when a user approve the entity
	approve: function (context) {
		// popup to ask to the approver to confirm that he want to approve the entity
		var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(context.data.entity.getEntityName());
		var confirmDialogStrings = {
			text: "Are you sure you want to approve this approval request?",
			confirmButtonLabel: "Approve"
		};
		var confirmationDialog = MsDynCrmApprovals.xrm.Navigation.openConfirmDialog(confirmDialogStrings);
		confirmationDialog.then(function (result) {
			if (result.confirmed) {
				// if the approver confirm that the entity can be approved
				// the statuscode of the entity must be set to "approved"
				context.getAttribute(Constants.statusCode).setValue(statusCodeFactory.getApproved());
				context.data.save().then(function () { context.ui.refreshRibbon(); }, function () { context.ui.refreshRibbon(); });
			}
		});
	},
	// check if the entity is in one of the stages that must be approved
	canReject: function (context) {
		var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(context.data.entity.getEntityName());
		var statusCode = context.getAttribute(Constants.statusCode).getValue();
		return statusCode === statusCodeFactory.getNeedApproval() ||
			statusCode === statusCodeFactory.getApproved();
	},
	// check if the entity is in one of the stages that must be approved
	needApprove: function (context) {
		var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(context.data.entity.getEntityName());
		var statusCode = context.getAttribute(Constants.statusCode).getValue();
		return window.Xrm.Page.data.entity.getId() !== "" && (statusCode === statusCodeFactory.getDraft() ||
			statusCode === statusCodeFactory.getStopped() ||
			statusCode === statusCodeFactory.getError() ||
			statusCode === statusCodeFactory.getLiveEditable());
	},
	// check if the entity is in one of the stages that can go live
	canGoLive: function (context) {
		var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(context.data.entity.getEntityName());
		var statusCode = context.getAttribute(Constants.statusCode).getValue();
		return statusCode === statusCodeFactory.getDraft() ||
			statusCode === statusCodeFactory.getStopped() ||
			statusCode === statusCodeFactory.getError() ||
			statusCode === statusCodeFactory.getLiveEditable() ||
			statusCode === statusCodeFactory.getApproved();
	},
	// used as enable rule to check that the user is an approver or that the entity is in approved state
	canIApprove: function (context) {
		var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(context.data.entity.getEntityName());
		var privilegesProvider = new MsDynCrmApprovals.Utilities.PrivilegesProvider();
		var statusCode = context.getAttribute(MsDynCrmApprovals.Constant.Constants.statusCode).getValue();
		return privilegesProvider.retrieveUserPrivileges(context) ||
			statusCode === statusCodeFactory.getApproved();
	},
	// used as enable rule to check that the user is a marketer
	iAmMarketer: function (context) {
		var privilegesProvider = new MsDynCrmApprovals.Utilities.PrivilegesProvider();
		return !privilegesProvider.retrieveUserPrivileges(context);
	},
	// set the value of fieldToRead in fieldToSet. 
	// In this example is used to set and restore msdyncrm_restorestatuscode
	setStatus: function (context, fieldToRead, fieldToSet) {
		var actualField = context.getAttribute(fieldToRead);
		var toSetField = context.getAttribute(fieldToSet);
		if (actualField != null && actualField.getValue() != null) {
			toSetField.setValue(actualField.getValue());
		}
	}
};
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
var MsDynCrmMkt;
(function (MsDynCrmMkt) {
MsDynCrmMkt.ExtensibilityCallback = {
	canGoLive: function () {
		return MsDynCrmApprovals.Handlers.canIApprove(MsDynCrmApprovals.xrm.Page) &&
			MsDynCrmApprovals.Handlers.canGoLive(MsDynCrmApprovals.xrm.Page);
	},
	liveEditablePreAction: function () {
	},
	customUpdateFormControls: function () {
		var privilegesProvider = new MsDynCrmApprovals.Utilities.PrivilegesProvider();
		var xrm = window.Xrm;
		privilegesProvider.getPrivilegeId().then(function (result) {
			if (result.entities) {
				var priviledgeId = result.entities[0].privilegeid;
				var roleIds = xrm.Page.context.getUserRoles();
				var promises = privilegesProvider.hasPrivileges(priviledgeId, roleIds);
				Promise.all(promises).then(function (result) {
					if (result.some(function (e) { return e.entities.length > 0; })) {
						var customFormFieldsControllerFactory = new MsDynCrmApprovals.Utilities.CustomFormFieldsControllerFactory(xrm);
						customFormFieldsControllerFactory.create(xrm.Page.data.entity.getEntityName()).updateControls();
					}
				});
			}
		}, function () { });
	},
	preventSave: function () {
		var xrm = window.Xrm;
		var statusCodeFactory = new MsDynCrmApprovals.Utilities.StatusCodeFactory().create(xrm.Page.data.entity.getEntityName());
		var isLiveEditable = xrm.Page.getAttribute(MsDynCrmApprovals.Constant.Constants.statusCode).getValue() === statusCodeFactory.getLiveEditable();
		if (isLiveEditable && MsDynCrmApprovals.Handlers.iAmMarketer(xrm.Page)) {
			return true;
		}
		return false;
	}
};
})(MsDynCrmMkt || (MsDynCrmMkt = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Utilities;
(function (Utilities) {
	var LocalizationProxy = /** @class */ (function () {
		function LocalizationProxy(inheritedJQuery) {
			LocalizationProxy.inheritedJQuery = inheritedJQuery;
		}
		LocalizationProxy.prototype.getLocalizationProvider = function (webResourceName) {
			var localizationDeferred = LocalizationProxy.inheritedJQuery.Deferred();
			var languageId, clientUrl;
			if (window.GetGlobalContext) {
				var context = window.GetGlobalContext();
				languageId = context.userSettings.languageId;
				clientUrl = context.getClientUrl();
			}
			else {
				var xrm = window.Xrm || window.parent.Xrm;
				languageId = xrm.Utility.getGlobalContext().userSettings.languageId;
				clientUrl = xrm.Utility.getGlobalContext().getClientUrl();
			}
			var labelPromise = this.getLabels(clientUrl, webResourceName, languageId);
			LocalizationProxy.inheritedJQuery.when(labelPromise)
				.done(function (labels) {
				var localizationProvider = new Utilities.LocalizationProvider(labels, languageId, false);
				localizationDeferred.resolve(localizationProvider);
			})
				.fail(function () {
				var localizationProvider = new Utilities.LocalizationProvider({ '': '' }, languageId, false);
				localizationDeferred.resolve(localizationProvider);
			});
			return localizationDeferred.promise();
		};
		LocalizationProxy.prototype.getLabels = function (crmBaseURL, labelsName, languageCode) {
			var labelsPromise = LocalizationProxy.inheritedJQuery.Deferred();
			LocalizationProxy.inheritedJQuery.getJSON(this.getLocalizationFilePath(crmBaseURL, labelsName, languageCode))
				.done(function (data) {
				var labels = {};
				LocalizationProxy.inheritedJQuery.each(data, function (key, val) {
					labels[key] = val.Value;
				});
				labelsPromise.resolve(labels);
			})
				.fail(function () {
				labelsPromise.resolve({});
			});
			return labelsPromise;
		};
		LocalizationProxy.prototype.getLocalizationFilePath = function (crmBaseURL, labelsName, languageCode) {
			return crmBaseURL + "/WebResources/msdyncrm_/Localizations/" + labelsName + languageCode;
		};
		return LocalizationProxy;
	}());
	Utilities.LocalizationProxy = LocalizationProxy;
})(Utilities = MsDynCrmApprovals.Utilities || (MsDynCrmApprovals.Utilities = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Utilities;
(function (Utilities) {
	/**
	 * Class for accessing localized strings
	 */
	var LocalizationProvider = /** @class */ (function () {
		function LocalizationProvider(labels, localeId, isRtl, labelsProvider) {
			if (isRtl === void 0) { isRtl = false; }
			if (labelsProvider === void 0) { labelsProvider = null; }
			this.allLabels = [];
			this.allLabels.push(labels);
			this.localeId = localeId;
			this.rtl = isRtl;
			this.labelsProvider = labelsProvider;
		}
		/**
		 * Gets the localized string
		 */
		LocalizationProvider.prototype.getLocalizedString = function (key) {
			for (var _i = 0, _a = this.allLabels; _i < _a.length; _i++) {
				var labels = _a[_i];
				if (key in labels) {
					return labels[key];
				}
			}
			return key;
		};
		/**
		 * Adds new label dictionary to find the localized strings in
		 */
		LocalizationProvider.prototype.addLabels = function (labels) {
			this.allLabels.push(labels);
		};
		/**
		 * Gets the labels provider responsible for getting string JSON file.
		 */
		LocalizationProvider.prototype.getLabelsProvider = function () {
			return this.labelsProvider;
		};
		/**
		 * Gets the locale id for the language assigned by Microsoft. For example, for English - United States it should returns 1033.
		 */
		LocalizationProvider.prototype.getLocaleId = function () {
			return this.localeId;
		};
		/**
		 * Gets the information whether the language is right to left.
		 */
		LocalizationProvider.prototype.isRtl = function () {
			return this.rtl;
		};
		return LocalizationProvider;
	}());
	Utilities.LocalizationProvider = LocalizationProvider;
})(Utilities = MsDynCrmApprovals.Utilities || (MsDynCrmApprovals.Utilities = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Utilities;
(function (Utilities) {
	var PrivilegesProvider = /** @class */ (function () {
		function PrivilegesProvider() {
		}
		PrivilegesProvider.prototype.retrieveUserPrivileges = function (context) {
			var _this = this;
			if (PrivilegesProvider.shouldRefresh) {
				return PrivilegesProvider.shouldRefresh;
			}
			this.getPrivilegeId().then(function (result) {
				if (result.entities) {
					var priviledgeId = result.entities[0].privilegeid;
					var roleIds = MsDynCrmApprovals.xrm.Page.context.getUserRoles();
					var promises = _this.hasPrivileges(priviledgeId, roleIds);
					Promise.all(promises).then(function (result) {
						if (result.some(function (elem) { return elem.entities.length > 0; })) {
							PrivilegesProvider.shouldRefresh = true;
							context.ui.refreshRibbon();
						}
						else {
							PrivilegesProvider.shouldRefresh = false;
						}
					});
				}
				else {
					PrivilegesProvider.shouldRefresh = false;
				}
			}, function () { PrivilegesProvider.shouldRefresh = false; });
			return false;
		};
		PrivilegesProvider.prototype.getPrivilegeId = function () {
			var filter = "?$select=privilegeid&$filter=name eq 'prvWritemsdyncrm_approval'";
			return MsDynCrmApprovals.xrm.WebApi.retrieveMultipleRecords(MsDynCrmApprovals.Constant.Table.privilege, filter);
		};
		PrivilegesProvider.prototype.hasPrivileges = function (privilegeId, roleIds) {
			var promises = [];
			roleIds.forEach(function (roleId) {
				var filter = "?$filter=privilegeid eq '" + privilegeId + "' and roleid eq '" + roleId + "'";
				promises.push(MsDynCrmApprovals.xrm.WebApi.retrieveMultipleRecords(MsDynCrmApprovals.Constant.Table.roleprivilegesCollection, filter));
			});
			return promises;
		};
		return PrivilegesProvider;
	}());
	Utilities.PrivilegesProvider = PrivilegesProvider;
})(Utilities = MsDynCrmApprovals.Utilities || (MsDynCrmApprovals.Utilities = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
/**
* @license Copyright (c) Microsoft Corporation. All rights reserved.
*/
var MsDynCrmApprovals;
(function (MsDynCrmApprovals) {
var Utilities;
(function (Utilities) {
	/**
	* Status code factory
	*/
	var StatusCodeFactory = /** @class */ (function () {
		function StatusCodeFactory() {
		}
		StatusCodeFactory.prototype.create = function (entityName) {
			if (entityName === MsDynCrmApprovals.Constant.Constants.marketingForm) {
				return new MsDynCrmApprovals.Constant.MarketingFormStatusCode();
			}
			return new MsDynCrmApprovals.Constant.DefaultTransientStatusCode();
		};
		return StatusCodeFactory;
	}());
	Utilities.StatusCodeFactory = StatusCodeFactory;
})(Utilities = MsDynCrmApprovals.Utilities || (MsDynCrmApprovals.Utilities = {}));
})(MsDynCrmApprovals || (MsDynCrmApprovals = {}));
//# sourceMappingURL=Approvals.CrmWebResource.js.map
```

### Step 3: Create ribbon buttons

In this step, we will create three custom ribbon buttons **Approve**, **Reject**, and **Ask approval**. To create custom ribbon buttons, see [Ribbon customizations](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/customize-dev/customize-commands-ribbon) or use any of the tools available in the Microsoft community. 

Use the below CustomActions, CommandDefinition, and EnableRules for the three custom ribbon buttons respectively.

**Approve button**

```XML
<CustomAction Id="msdyncrm.msdyncrm_customerjourney.Approve.CustomAction" Location="Mscrm.Form.msdyncrm_customerjourney.MainTab.Save.Controls._children" Sequence="73">
      <CommandUIDefinition>
        <Button Alt="$LocLabels:msdyncrm.msdyncrm_customerjourney.Approve.Button.Alt" Image16by16="/_imgs/imagestrips/transparent_spacer.gif" Command="msdyncrm.msdyncrm_customerjourney.Approve.Command" Description="Approve" Id="msdyncrm.msdyncrm_customerjourney.Approve.Button" LabelText="$LocLabels:msdyncrm.msdyncrm_customerjourney.Approve.Button.LabelText" Sequence="73" TemplateAlias="o1" ToolTipTitle="$LocLabels:msdyncrm.msdyncrm_customerjourney.Approve.Button.ToolTipTitle" ToolTipDescription="$LocLabels:msdyncrm.msdyncrm_customerjourney.Approve.Button.ToolTipDescription" ModernImage="SuccessIcon" />
      </CommandUIDefinition>
    </CustomAction>
<CommandDefinition Id="msdyncrm.msdyncrm_customerjourney.Approve.Command">
      <EnableRules>
        <EnableRule Id="msdyncrm.msdyncrm_customerjourney.CanApprove.EnableRule" />
        <EnableRule Id="msdyncrm.msdyncrm_customerjourney.iAmApprover.EnableRule" /> 
      </EnableRules>
      <DisplayRules />
      <Actions>
        <JavaScriptFunction FunctionName="MsDynCrmApprovals.Handlers.approve" Library="$webresource:msdyncrm_Approvals.CrmWebResource">
          <CrmParameter Value="SelectedControl" />
        </JavaScriptFunction>
      </Actions>
    </CommandDefinition>
  </CommandDefinitions>
<EnableRule Id="msdyncrm.msdyncrm_customerjourney.CanApprove.EnableRule">
        <ValueRule Field="statuscode" InvertResult="false" Value="812250000" Default="false" />
      </EnableRule>
<EnableRule Id="msdyncrm.msdyncrm_customerjourney.iAmApprover.EnableRule">
        <CustomRule FunctionName="MsDynCrmApprovals.Handlers.canIApprove" Library="$webresource:msdyncrm_Approvals.CrmWebResource" Default="false" >
          <CrmParameter Value="SelectedControl" />
        </CustomRule>
      </EnableRule>
``` 

**Reject button**

```XML
<CustomAction Id="msdyncrm.msdyncrm.msdyncrm_customerjourney.Reject.CustomAction" Location="Mscrm.Form.msdyncrm_customerjourney.MainTab.Save.Controls._children" Sequence="74">
      <CommandUIDefinition>
        <Button Alt="$LocLabels:msdyncrm.msdyncrm_customerjourney.Reject.Button.Alt" Command="msdyncrm.msdyncrm_customerjourney.Reject.Command" Id="msdyncrm.msdyncrm_customerjourney.Reject.Button" Image32by32="" Image16by16="/_imgs/imagestrips/transparent_spacer.gif" LabelText="$LocLabels:msdyncrm.msdyncrm_customerjourney.Reject.Button.LabelText" Sequence="74" TemplateAlias="o1" ToolTipTitle="$LocLabels:msdyncrm.msdyncrm_customerjourney.Reject.Button.ToolTipTitle" ToolTipDescription="$LocLabels:msdyncrm.msdyncrm_customerjourney.Reject.Button.ToolTipDescription" ModernImage="Close" />
      </CommandUIDefinition>
    </CustomAction>
<CommandDefinition Id="msdyncrm.msdyncrm_customerjourney.Reject.Command">
      <EnableRules>
        <EnableRule Id="msdyncrm.msdyncrm_customerjourney.CanReject.EnableRule" />
        <EnableRule Id="msdyncrm.msdyncrm_customerjourney.iAmApprover.EnableRule" /> 
      </EnableRules>
      <DisplayRules />
      <Actions>
        <JavaScriptFunction FunctionName="MsDynCrmApprovals.Handlers.restoreStatusCode" Library="$webresource:msdyncrm_Approvals.CrmWebResource">
          <CrmParameter Value="SelectedControl" />
        </JavaScriptFunction>
      </Actions>
    </CommandDefinition>
<EnableRule Id="msdyncrm.msdyncrm_customerjourney.CanReject.EnableRule">
        <CustomRule FunctionName="MsDynCrmApprovals.Handlers.canReject" Library="$webresource:msdyncrm_Approvals.CrmWebResource" Default="false" InvertResult="false" >
          <CrmParameter Value="SelectedControl" />
        </CustomRule>
      </EnableRule>
```

**Ask approval button**

```XML
<CustomAction Id="msdyncrm.msdyncrm.msdyncrm_customerjourney.AskApproval.CustomAction" Location="Mscrm.Form.msdyncrm_customerjourney.MainTab.Save.Controls._children" Sequence="74">
      <CommandUIDefinition>
        <Button Alt="$LocLabels:msdyncrm.msdyncrm_customerjourney.AskApproval.Button.Alt" Command="msdyncrm.msdyncrm_customerjourney.AskApproval.Command" Id="msdyncrm.msdyncrm_customerjourney.AskApproval.Button" Image32by32="" Image16by16="/_imgs/imagestrips/transparent_spacer.gif" LabelText="$LocLabels:msdyncrm.msdyncrm_customerjourney.AskApproval.Button.LabelText" Sequence="74" TemplateAlias="o1" ToolTipTitle="$LocLabels:msdyncrm.msdyncrm_customerjourney.AskApproval.Button.ToolTipTitle" ToolTipDescription="$LocLabels:msdyncrm.msdyncrm_customerjourney.AskApproval.Button.ToolTipDescription" ModernImage="Warning" />
      </CommandUIDefinition>
    </CustomAction>
<CommandDefinition Id="msdyncrm.msdyncrm_customerjourney.AskApproval.Command">
      <EnableRules>
        <EnableRule Id="msdyncrm.msdyncrm_customerjourney.NeedApprove.EnableRule" />
        <EnableRule Id="msdyncrm.msdyncrm_customerjourney.iAmMarketer.EnableRule" />
      </EnableRules>
      <DisplayRules>
      </DisplayRules>
      <Actions>
        <JavaScriptFunction FunctionName="MsDynCrmApprovals.Handlers.askApprovals" Library="$webresource:msdyncrm_Approvals.CrmWebResource">
          <CrmParameter Value="SelectedControl" />
        </JavaScriptFunction>
      </Actions>
    </CommandDefinition> 
<EnableRule Id="msdyncrm.msdyncrm_customerjourney.NeedApprove.EnableRule">
        <CustomRule FunctionName="MsDynCrmApprovals.Handlers.needApprove" Library="$webresource:msdyncrm_Approvals.CrmWebResource" Default="false" InvertResult="false" >
          <CrmParameter Value="SelectedControl" />
        </CustomRule>
      </EnableRule> 
<EnableRule Id="msdyncrm.msdyncrm_customerjourney.iAmMarketer.EnableRule">
        <CustomRule FunctionName="MsDynCrmApprovals.Handlers.iAmMarketer" Library="$webresource:msdyncrm_Approvals.CrmWebResource" Default="false" InvertResult="false" >
          <CrmParameter Value="SelectedControl" />
        </CustomRule>
      </EnableRule>

```

## Integrate with Microsoft Flow

Microsoft Flow has a connector for approvals that we can reuse. To do so, create a new flow inside the **Sample approval** solution (in this way, we can export and reuse the solution). To achieve the scenario above, we need to follow the steps below: 

1. Trigger the new flow when a customer journey is updated, in particular when the **statuscode=need approval**. 
2. If the status code is equal to need approval, then we want to go ahead with our flow
3. To configure in a more generic way the next steps, create two new fields inside the customer journey.
   - **msdyncrm_organizationurl** that contains the URL of the organization.
   - **msdyncrm_approvers** that contains the email address of the manager.
4. Create a plugin that fills these new fields on the retrieve of the entity.
5. We can use the default approval connector to notify the approvers that a new customer journey needs, to be checked. Based on the response, we can change the **statuscode** value of the entity (restore the initial value or go to the approved stage).

