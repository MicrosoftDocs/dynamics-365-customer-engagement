var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var ApiFlags;
        (function (ApiFlags) {
            ApiFlags[ApiFlags["none"] = 0] = "none";
            ApiFlags[ApiFlags["restrictedResource"] = 4] = "restrictedResource";
            ApiFlags[ApiFlags["makerSafe"] = 128] = "makerSafe";
            ApiFlags[ApiFlags["excludedFromDefaultLoad"] = 256] = "excludedFromDefaultLoad";
            ApiFlags[ApiFlags["notNull"] = 1024] = "notNull";
        })(ApiFlags = WacRuntime.ApiFlags || (WacRuntime.ApiFlags = {}));
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var Constants = (function () {
            function Constants() {
            }
            Constants.httpMethodGet = "GET";
            Constants.httpMethodPost = "POST";
            Constants.httpMethodPatch = "PATCH";
            Constants.httpMethodDelete = "DELETE";
            Constants.processQuery = "ProcessQuery";
            Constants.actionId = "ActionId";
            Constants.actionIndex = "ActionIndex";
            Constants.actions = "Actions";
            Constants.arrayTypeSufix = "[]";
            Constants.code = "Code";
            Constants.count = "Count";
            Constants.error = "Error";
            Constants.expand = "Expand";
            Constants.getAsyncEnumeratorJsName = "getAsyncEnumerator";
            Constants.getCount = "GetCount";
            Constants.getItemAt = "GetItemAt";
            Constants.getObjectByReferenceId = "_GetObjectByReferenceId";
            Constants.getReferenceCount = "_GetReferenceCount";
            Constants.id = "Id";
            Constants.idLowerCase = "id";
            Constants.idPrivate = "_Id";
            Constants.idPrivateLowerCase = "_id";
            Constants.index = "_Index";
            Constants.isNull = "_IsNull";
            Constants.items = "_Items";
            Constants.keepReference = "_KeepReference";
            Constants.location = "Location";
            Constants.maxRecursiveQueryDepth = 100;
            Constants.message = "Message";
            Constants.nullableTypeSuffix = "?";
            Constants.objectPathIdPrivate = "_ObjectPathId";
            Constants.onAccess = "_OnAccess";
            Constants.processedResults = "ProcessedResults";
            Constants.referenceId = "_ReferenceId";
            Constants.referenceIdLowerCase = "_referenceid";
            Constants.removeAllReferences = "_RemoveAllReferences";
            Constants.removeReference = "_RemoveReference";
            Constants.results = "Results";
            Constants.traceIds = "TraceIds";
            Constants.value = "Value";
            return Constants;
        }());
        WacRuntime.Constants = Constants;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var EventManager = (function () {
            function EventManager() {
                this.m_eventIdControlMapByTarget = {};
                this.m_richApiMessageEntriesByControl = {};
                this.m_batchFireEventScheduled = false;
            }
            EventManager.prototype.initHost = function (host) {
                this.m_host = host;
            };
            EventManager.prototype.register = function (controlId, targetId, eventId) {
                targetId = this.normalizeTargetId(targetId);
                var eventIdControlMap = this.m_eventIdControlMapByTarget[targetId];
                if (!eventIdControlMap) {
                    eventIdControlMap = {};
                    this.m_eventIdControlMapByTarget[targetId] = eventIdControlMap;
                }
                var controlCountMap = eventIdControlMap[eventId];
                if (!controlCountMap) {
                    controlCountMap = {};
                    eventIdControlMap[eventId] = controlCountMap;
                }
                if (typeof (controlCountMap[controlId]) === 'undefined') {
                    controlCountMap[controlId] = 1;
                }
                else {
                    controlCountMap[controlId] = controlCountMap[controlId] + 1;
                }
                if (controlCountMap[controlId] === 1) {
                    if (this.m_host) {
                        this.m_host.onRegisterRichApiEvent(targetId, eventId);
                    }
                }
            };
            EventManager.prototype.unregister = function (controlId, targetId, eventId) {
                targetId = this.normalizeTargetId(targetId);
                var eventIdControlMap = this.m_eventIdControlMapByTarget[targetId];
                if (eventIdControlMap) {
                    var controlCountMap = eventIdControlMap[eventId];
                    if (controlCountMap) {
                        if (controlCountMap[controlId] > 0) {
                            if (controlCountMap[controlId] === 1) {
                                if (this.m_host) {
                                    this.m_host.onUnregisterRichApiEvent(targetId, eventId);
                                }
                                delete controlCountMap[controlId];
                            }
                            else {
                                controlCountMap[controlId] = controlCountMap[controlId] - 1;
                            }
                        }
                    }
                }
            };
            EventManager.prototype.isEventRegistered = function (targetId, eventId) {
                targetId = this.normalizeTargetId(targetId);
                var eventIdControlMap = this.m_eventIdControlMapByTarget[targetId];
                if (!eventIdControlMap) {
                    return false;
                }
                var controlCountMap = eventIdControlMap[eventId];
                if (!controlCountMap) {
                    return false;
                }
                for (var key in controlCountMap) {
                    return true;
                }
                return false;
            };
            EventManager.prototype.fireEvent = function (targetId, eventId, eventData) {
                var _this = this;
                targetId = this.normalizeTargetId(targetId);
                var eventIdControlMap = this.m_eventIdControlMapByTarget[targetId];
                if (!eventIdControlMap) {
                    return;
                }
                var controlCountMap = eventIdControlMap[eventId];
                if (!controlCountMap) {
                    return;
                }
                for (var controlId in controlCountMap) {
                    var richApiMessageEntries = this.m_richApiMessageEntriesByControl[controlId];
                    if (!richApiMessageEntries) {
                        richApiMessageEntries = [];
                        this.m_richApiMessageEntriesByControl[controlId] = richApiMessageEntries;
                    }
                    var oneMessageEntry = [EventManager.s_richapiMessageCategoryEvent, eventId, targetId, JSON.stringify(eventData)];
                    richApiMessageEntries.push(oneMessageEntry);
                }
                if (!this.m_batchFireEventScheduled) {
                    this.m_batchFireEventScheduled = true;
                    setTimeout(function () {
                        _this.batchFireEvent();
                    }, 0);
                }
            };
            EventManager.prototype.batchFireEvent = function () {
                this.m_batchFireEventScheduled = false;
                var richApiMessageEntriesByControl = this.m_richApiMessageEntriesByControl;
                this.m_richApiMessageEntriesByControl = {};
                for (var controlId in richApiMessageEntriesByControl) {
                    var messageEntries = richApiMessageEntriesByControl[controlId];
                    if (this.m_host) {
                        this.m_host.sendRichApiMessageEventEntriesToControl(controlId, messageEntries);
                    }
                }
            };
            EventManager.prototype.normalizeTargetId = function (targetId) {
                if (WacRuntime.Utility.isNullOrUndefined(targetId)) {
                    return "";
                }
                return targetId;
            };
            EventManager.s_richapiMessageCategoryEvent = 65536;
            return EventManager;
        }());
        WacRuntime.EventManager = EventManager;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var ErrorCodes = (function () {
            function ErrorCodes() {
            }
            ErrorCodes.accessDenied = "AccessDenied";
            ErrorCodes.apiNotFound = "ApiNotFound";
            ErrorCodes.generalException = "GeneralException";
            ErrorCodes.invalidArgument = "InvalidArgument";
            ErrorCodes.invalidOperation = "InvalidOperation";
            ErrorCodes.invalidRequest = "InvalidRequest";
            return ErrorCodes;
        }());
        WacRuntime.ErrorCodes = ErrorCodes;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var JsComRequestProcessor = (function () {
            function JsComRequestProcessor(context) {
                this.m_context = context;
                this.m_requestMessage = JSON.parse(this.m_context.request.body);
                this.m_objectPaths = {};
                this.m_resolvedObjects = {};
                this.m_traceIds = [];
            }
            JsComRequestProcessor.prototype.process = function () {
                var _this = this;
                this.m_context.response.writer.startObjectScope();
                this.m_context.response.writer.writeName(WacRuntime.Constants.results);
                this.m_context.response.writer.startArrayScope();
                var ret = WacRuntime.Utility.createPromiseFromResult(null);
                for (var i = 0; i < this.m_requestMessage.Actions.length; i++) {
                    var actionWriter = new WacRuntime.JsonWriter();
                    var func = this.createProcessOneActionFunc(actionWriter, this.m_requestMessage.Actions[i], i);
                    ret = ret.then(func);
                    var func2 = this.createWriteActionWriterFunc(this.m_context.response.writer, actionWriter);
                    ret = ret.then(func2);
                }
                return ret.then(function () {
                    _this.m_context.response.writer.endScope();
                    _this.writeTraceIds(_this.m_context.response.writer);
                    _this.m_context.response.writer.endScope();
                })["catch"](function (err) {
                    _this.processError(err);
                });
            };
            JsComRequestProcessor.prototype.processError = function (error) {
                var writerProcessedResults = this.m_context.response.reset();
                var writer = this.m_context.response.writer;
                var richApiEx = WacRuntime.UtilityInternal.convertToRichApiException(error);
                writer.startObjectScope();
                writer.writeName(WacRuntime.Constants.error);
                JsComRequestProcessor.writeError(writer, richApiEx, this.m_currentActionIndex);
                this.writeTraceIds(writer);
                if (!writerProcessedResults.isEmpty) {
                    writer.writeName(WacRuntime.Constants.processedResults);
                    writer.writeRawValueFrom(writerProcessedResults);
                }
                writer.endScope();
                WacRuntime.Logger.SendULSTraceTag(JSON.stringify(richApiEx), this.m_context.host.hostName(), 50, 0x02194840);
            };
            JsComRequestProcessor.writeError = function (writer, richApiEx, actionIndex) {
                writer.startObjectScope();
                writer.writeName(WacRuntime.Constants.code);
                writer.writeValue(richApiEx.code);
                writer.writeName(WacRuntime.Constants.message);
                writer.writeValue(richApiEx.message);
                if (!WacRuntime.Utility.isNullOrEmptyString(richApiEx.location)) {
                    writer.writeName(WacRuntime.Constants.location);
                    writer.writeValue(richApiEx.location);
                }
                if (actionIndex >= 0) {
                    writer.writeName(WacRuntime.Constants.actionIndex);
                    writer.writeValue(actionIndex);
                }
                writer.endScope();
            };
            JsComRequestProcessor.prototype.createProcessOneActionFunc = function (writer, action, actionIndex) {
                var _this = this;
                return function () {
                    return WacRuntime.Utility.createPromiseFromResult(null)
                        .then(function () {
                        _this.m_currentActionIndex = actionIndex;
                        return _this.processOneAction(writer, action);
                    });
                };
            };
            JsComRequestProcessor.prototype.createWriteActionWriterFunc = function (writer, actionWriter) {
                return function () {
                    if (actionWriter.isEmpty) {
                        throw WacRuntime.Utility.createInvalidOperationException();
                    }
                    writer.writeRawValueFrom(actionWriter);
                };
            };
            JsComRequestProcessor.prototype.processOneAction = function (writer, action) {
                switch (action.ActionType) {
                    case 1:
                        return this.processActionInstantiate(writer, action);
                    case 3:
                        return this.processActionMethod(writer, action);
                    case 2:
                        return this.processActionQuery(writer, action);
                    case 4:
                        return this.processActionSetProperty(writer, action);
                    case 5:
                        return this.procesActionTrace(writer, action);
                    case 6:
                        return this.processActionRecursiveQuery(writer, action);
                    default:
                        throw WacRuntime.Utility.createInvalidOperationException();
                }
            };
            JsComRequestProcessor.prototype.processActionInstantiate = function (writer, action) {
                var _this = this;
                return this.getObjectFromObjectPathId(action.ObjectPathId)
                    .then(function (obj) {
                    var donotKeepReference = _this.shouldNotKeepReference(action.ObjectPathId);
                    return _this.invokeKeepReferenceIfNecessary(donotKeepReference, obj);
                })
                    .then(function (obj) {
                    writer.startObjectScope();
                    writer.writeName(WacRuntime.Constants.actionId);
                    writer.writeValue(action.Id);
                    writer.writeName(WacRuntime.Constants.value);
                    if (obj) {
                        return _this.writeObjectBasicIds(writer, obj).then(function () {
                            writer.endScope();
                        });
                    }
                    else {
                        writer.writeValueNull();
                        writer.endScope();
                    }
                });
            };
            JsComRequestProcessor.prototype.writeObjectBasicIds = function (writer, obj) {
                var _this = this;
                var typeInfo = this.m_context.typeReg.getType(obj.getTypeName());
                writer.startObjectScope();
                var p = WacRuntime.Utility.createPromiseFromResult(null);
                p = p.then(function () {
                    var idPropInfo = typeInfo.tryGetProperty(WacRuntime.Constants.id);
                    if (idPropInfo) {
                        return WacRuntime.UtilityInternal.invokePropertyGetAsync(_this.m_context, typeInfo, idPropInfo, obj).then(function (id) {
                            writer.writeName(WacRuntime.Constants.id);
                            writer.writeValue(id);
                        });
                    }
                });
                p = p.then(function () {
                    var idPropInfo = typeInfo.tryGetProperty(WacRuntime.Constants.idPrivate);
                    if (idPropInfo) {
                        return WacRuntime.UtilityInternal.invokePropertyGetAsync(_this.m_context, typeInfo, idPropInfo, obj).then(function (id) {
                            writer.writeName(WacRuntime.Constants.idPrivate);
                            writer.writeValue(id);
                        });
                    }
                });
                p = p.then(function () {
                    var referenceIdPropInfo = typeInfo.tryGetProperty(WacRuntime.Constants.referenceId);
                    if (referenceIdPropInfo) {
                        return WacRuntime.UtilityInternal.invokePropertyGetAsync(_this.m_context, typeInfo, referenceIdPropInfo, obj).then(function (referenceId) {
                            if (typeof (referenceId) == "string" && !WacRuntime.Utility.isNullOrEmptyString(referenceId)) {
                                writer.writeName(WacRuntime.Constants.referenceId);
                                writer.writeValue(referenceId);
                            }
                        });
                    }
                });
                p = p.then(function () {
                    writer.endScope();
                });
                return p;
            };
            JsComRequestProcessor.prototype.processActionMethod = function (writer, action) {
                var _this = this;
                return this.getObjectFromObjectPathId(action.ObjectPathId).then(function (obj) {
                    if (!obj) {
                        _this.writeActionNullObjectResult(writer, action);
                    }
                    else {
                        var typeInfo = _this.m_context.typeReg.getType(obj.getTypeName());
                        var methodInfo = typeInfo.getMethod(action.Name);
                        return _this.resolveMethodArguments(action.ArgumentInfo, methodInfo.parameters).then(function (args) {
                            return WacRuntime.UtilityInternal.invokeMethodAsync(_this.m_context, typeInfo, methodInfo, obj, args).then(function (value) {
                                writer.startObjectScope();
                                writer.writeName(WacRuntime.Constants.actionId);
                                writer.writeValue(action.Id);
                                writer.writeName(WacRuntime.Constants.value);
                                var returnTypeInfo = _this.m_context.typeReg.tryGetType(methodInfo.returnTypeName);
                                WacRuntime.UtilityInternal.writeValue(writer, _this.m_context, returnTypeInfo, value);
                                writer.endScope();
                            });
                        });
                    }
                });
            };
            JsComRequestProcessor.prototype.processActionQuery = function (writer, action) {
                var _this = this;
                return this.getObjectFromObjectPathId(action.ObjectPathId).then(function (obj) {
                    writer.startObjectScope();
                    writer.writeName(WacRuntime.Constants.actionId);
                    writer.writeValue(action.Id);
                    writer.writeName(WacRuntime.Constants.value);
                    if (obj) {
                        var typeInfo = _this.m_context.typeReg.getType(obj.getTypeName());
                        var query = new WacRuntime.RESTfulQuery();
                        query.init(action.QueryInfo.Select, action.QueryInfo.Expand, action.QueryInfo.Top, action.QueryInfo.Skip);
                        var donotKeepReference = _this.shouldNotKeepReference(action.ObjectPathId);
                        return _this.writeQueryResult(writer, query, obj, typeInfo, -1, null, 1, donotKeepReference).then(function () {
                            writer.endScope();
                        });
                    }
                    else {
                        writer.writeValueNull();
                        writer.endScope();
                    }
                });
            };
            JsComRequestProcessor.prototype.processActionRecursiveQuery = function (writer, action) {
                var _this = this;
                if (WacRuntime.Utility.isNullOrUndefined(action.RecursiveQueryInfo)) {
                    throw WacRuntime.Utility.createInvalidArgumentException("action.RecursiveQueryInfo");
                }
                var queries = {};
                if (action.RecursiveQueryInfo.Queries) {
                    for (var key in action.RecursiveQueryInfo.Queries) {
                        queries[key.toLowerCase()] = action.RecursiveQueryInfo.Queries[key];
                    }
                }
                var recursiveQueryInfo = {
                    Queries: queries,
                    MaxDepth: action.RecursiveQueryInfo.MaxDepth
                };
                if (WacRuntime.Utility.isNullOrUndefined(recursiveQueryInfo.MaxDepth)) {
                    recursiveQueryInfo.MaxDepth = WacRuntime.Constants.maxRecursiveQueryDepth;
                }
                if (recursiveQueryInfo.MaxDepth < 0 || recursiveQueryInfo.MaxDepth > WacRuntime.Constants.maxRecursiveQueryDepth) {
                    throw WacRuntime.Utility.createInvalidArgumentException("action.RecursiveQueryInfo.MaxDepth");
                }
                return this.getObjectFromObjectPathId(action.ObjectPathId).then(function (obj) {
                    writer.startObjectScope();
                    writer.writeName(WacRuntime.Constants.actionId);
                    writer.writeValue(action.Id);
                    writer.writeName(WacRuntime.Constants.value);
                    if (obj) {
                        var typeInfo = _this.m_context.typeReg.getType(obj.getTypeName());
                        var query = new WacRuntime.RESTfulQuery();
                        _this.tryGetQueryForType(recursiveQueryInfo, typeInfo, query);
                        var donotKeepReference = _this.shouldNotKeepReference(action.ObjectPathId);
                        return _this.writeQueryResult(writer, query, obj, typeInfo, -1, recursiveQueryInfo, 1, donotKeepReference).then(function () {
                            writer.endScope();
                        });
                    }
                    else {
                        writer.writeValueNull();
                        writer.endScope();
                    }
                });
            };
            JsComRequestProcessor.prototype.processActionSetProperty = function (writer, action) {
                var _this = this;
                return this.getObjectFromObjectPathId(action.ObjectPathId).then(function (obj) {
                    if (obj) {
                        var typeInfo = _this.m_context.typeReg.getType(obj.getTypeName());
                        var propInfo = typeInfo.getProperty(action.Name);
                        return _this.resolveMethodArguments(action.ArgumentInfo, propInfo.parameters).then(function (args) {
                            return WacRuntime.UtilityInternal.invokePropertySetAsync(_this.m_context, typeInfo, propInfo, obj, args[0]);
                        }).then(function () {
                            _this.writeActionNullResult(writer, action);
                        });
                    }
                    else {
                        _this.writeActionNullObjectResult(writer, action);
                    }
                });
            };
            JsComRequestProcessor.prototype.writeActionNullResult = function (writer, action) {
                writer.startObjectScope();
                writer.writeName(WacRuntime.Constants.actionId);
                writer.writeValue(action.Id);
                writer.writeName(WacRuntime.Constants.value);
                writer.writeValueNull();
                writer.endScope();
            };
            JsComRequestProcessor.prototype.writeActionNullObjectResult = function (writer, action) {
                writer.startObjectScope();
                writer.writeName(WacRuntime.Constants.actionId);
                writer.writeValue(action.Id);
                writer.writeName(WacRuntime.Constants.value);
                writer.startObjectScope();
                writer.writeName(WacRuntime.Constants.isNull);
                writer.writeValue(true);
                writer.endScope();
                writer.endScope();
            };
            JsComRequestProcessor.prototype.procesActionTrace = function (writer, action) {
                var _this = this;
                return WacRuntime.Utility.createPromiseFromResult(null).then(function () {
                    _this.m_traceIds.push(action.Id);
                    _this.writeActionNullResult(writer, action);
                });
            };
            JsComRequestProcessor.prototype.shouldNotKeepReference = function (objectPathId) {
                return this.m_requestMessage.ObjectPaths[objectPathId].D;
            };
            JsComRequestProcessor.prototype.getObjectFromObjectPathId = function (objectPathId) {
                var _this = this;
                var ret = this.m_objectPaths[objectPathId];
                if (ret) {
                    return ret.then(function (obj) {
                        return _this.invokeOnAccess(obj);
                    });
                }
                ret = this.createObjectFromObjectPath(this.m_requestMessage.ObjectPaths[objectPathId]);
                ret = ret.then(function (obj) {
                    _this.m_resolvedObjects[objectPathId] = obj;
                    return obj;
                });
                this.m_objectPaths[objectPathId] = ret;
                return ret.then(function (obj) {
                    return _this.invokeOnAccess(obj);
                });
            };
            JsComRequestProcessor.prototype.getResolvedObjectFromObjectPathId = function (objectPathId) {
                var ret = this.m_resolvedObjects[objectPathId];
                if (WacRuntime.Utility.isUndefined(ret)) {
                    throw WacRuntime.Utility.createInvalidRequestException();
                }
                return ret;
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPath = function (objectPath) {
                switch (objectPath.ObjectPathType) {
                    case 1:
                        return this.createObjectFromObjectPathGlobalObject(objectPath);
                    case 5:
                        return this.createObjectFromObjectPathIndexer(objectPath);
                    case 3:
                        return this.createObjectFromObjectPathMethod(objectPath);
                    case 2:
                        return this.createObjectFromObjectPathNewObject(objectPath);
                    case 4:
                        return this.createObjectFromObjectPathProperty(objectPath);
                    case 6:
                        return this.createObjectFromObjectPathReferenceId(objectPath);
                    case 7:
                        return WacRuntime.Utility.createPromiseFromResult(null);
                }
                throw WacRuntime.Utility.createInvalidOperationException();
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPathGlobalObject = function (objectPath) {
                var obj = this.m_context.request.globalObject;
                return WacRuntime.Utility.createPromiseFromResult(obj);
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPathIndexer = function (objectPath) {
                var _this = this;
                return this.getObjectFromObjectPathId(objectPath.ParentObjectPathId).then(function (parent) {
                    if (!parent) {
                        return null;
                    }
                    var typeInfo = _this.m_context.typeReg.getType(parent.getTypeName());
                    var method = typeInfo.getIndexerMethod();
                    return WacRuntime.UtilityInternal.invokeMethodAsync(_this.m_context, typeInfo, method, parent, objectPath.ArgumentInfo.Arguments);
                });
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPathMethod = function (objectPath) {
                var _this = this;
                return this.getObjectFromObjectPathId(objectPath.ParentObjectPathId).then(function (parent) {
                    if (!parent) {
                        return null;
                    }
                    var typeInfo = _this.m_context.typeReg.getType(parent.getTypeName());
                    var method = typeInfo.getMethod(objectPath.Name);
                    return _this.resolveMethodArguments(objectPath.ArgumentInfo, method.parameters).then(function (args) {
                        return WacRuntime.UtilityInternal.invokeMethodAsync(_this.m_context, typeInfo, method, parent, args);
                    });
                });
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPathNewObject = function (objectPath) {
                var typeName = objectPath.Name;
                var typeInfo = this.m_context.typeReg.getType(typeName);
                var obj = WacRuntime.UtilityInternal.createObject(this.m_context, typeInfo);
                return WacRuntime.Utility.createPromiseFromResult(obj);
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPathProperty = function (objectPath) {
                var _this = this;
                return this.getObjectFromObjectPathId(objectPath.ParentObjectPathId).then(function (parent) {
                    if (!parent) {
                        return null;
                    }
                    var typeInfo = _this.m_context.typeReg.getType(parent.getTypeName());
                    var propInfo = typeInfo.getProperty(objectPath.Name);
                    return WacRuntime.UtilityInternal.invokePropertyGetAsync(_this.m_context, typeInfo, propInfo, parent);
                });
            };
            JsComRequestProcessor.prototype.createObjectFromObjectPathReferenceId = function (objectPath) {
                var referenceId = objectPath.Name;
                var typeInfo = this.m_context.typeReg.getType(this.m_context.request.globalObject.getTypeName());
                var getObjectMethodInfo = typeInfo.getMethod(WacRuntime.Constants.getObjectByReferenceId);
                return WacRuntime.UtilityInternal.invokeMethodAsync(this.m_context, typeInfo, getObjectMethodInfo, this.m_context.request.globalObject, [referenceId]);
            };
            JsComRequestProcessor.prototype.resolveMethodArguments = function (args, parameters) {
                var ret = [];
                for (var i = 0; i < parameters.length && i < args.Arguments.length; i++) {
                    ret.push(args.Arguments[i]);
                }
                for (var i = 0; i < parameters.length && i < ret.length; i++) {
                    var typeInfo = this.m_context.typeReg.tryGetType(parameters[i].parameterTypeName);
                    if (!WacRuntime.Utility.isNullOrEmptyString(parameters[i].fallbackComplexTypeName)) {
                        var complexTypeInfo = this.m_context.typeReg.getType(parameters[i].fallbackComplexTypeName);
                        ret[i] = this.resolveComplexTypeIfNecessary(ret[i], complexTypeInfo);
                    }
                    else if (parameters[i].parameterTypeName.indexOf("DateTime") >= 0) {
                        ret[i] = this.convertStringValueToDateValue(ret[i]);
                    }
                    else if (typeInfo) {
                        ret[i] = this.resolveEnumIntValueIfHasEnumType(ret[i], typeInfo);
                    }
                }
                var promise = WacRuntime.Utility.createPromiseFromResult(null);
                if (args.ReferencedObjectPathIds) {
                    var objectPathIdInfos = [];
                    for (var i = 0; i < ret.length; i++) {
                        this.collectObjectPathIdInfos(objectPathIdInfos, [i], ret[i], args.ReferencedObjectPathIds[i]);
                    }
                    for (var i = 0; i < objectPathIdInfos.length; i++) {
                        var func = this.createGetObjectFromObjectPathIdAndStoreParameterArgFunc(objectPathIdInfos[i].objectPathId, ret, objectPathIdInfos[i].indices);
                        promise = promise.then(func);
                    }
                }
                return promise.then(function () {
                    return WacRuntime.Utility.createPromiseFromResult(ret);
                });
            };
            JsComRequestProcessor.prototype.convertStringValueToDateValue = function (value) {
                if (WacRuntime.Utility.isNullOrUndefined(value)) {
                    return null;
                }
                if (typeof (value) === "string") {
                    if (!JsComRequestProcessor.s_regexISODate.test(value)) {
                        throw WacRuntime.Utility.createInvalidArgumentException("value");
                    }
                    var dateValue = Date.parse(value);
                    if (WacRuntime.Utility.isNullOrUndefined(dateValue)) {
                        throw WacRuntime.Utility.createInvalidArgumentException("value");
                    }
                    return new Date(dateValue);
                }
                if (Array.isArray(value)) {
                    var arr = value;
                    for (var i = 0; i < arr.length; i++) {
                        arr[i] = this.convertStringValueToDateValue(arr[i]);
                    }
                    return arr;
                }
                return value;
            };
            JsComRequestProcessor.prototype.resolveComplexTypeIfNecessary = function (value, complexTypeInfo) {
                if (Array.isArray(value)) {
                    var items = value;
                    for (var i = 0; i < items.length; i++) {
                        items[i] = this.resolveComplexTypeIfNecessary(items[i], complexTypeInfo);
                    }
                    return items;
                }
                if (typeof (value) == "object") {
                    var obj = WacRuntime.UtilityInternal.createObject(this.m_context, complexTypeInfo);
                    for (var propName in value) {
                        var propInfo = complexTypeInfo.tryGetProperty(propName);
                        if (propInfo && !propInfo.isReadonly) {
                            var propValue = value[propName];
                            var propTypeInfo = this.m_context.typeReg.tryGetType(propInfo.propertyTypeName);
                            if (!WacRuntime.Utility.isNullOrEmptyString(propInfo.fallbackComplexTypeName)) {
                                var propComplexTypeInfo = this.m_context.typeReg.getType(propInfo.fallbackComplexTypeName);
                                propValue = this.resolveComplexTypeIfNecessary(propValue, propComplexTypeInfo);
                            }
                            else if (typeof (propValue) === "object" && propValue && typeof (propValue[WacRuntime.Constants.objectPathIdPrivate]) === "number" && propValue[WacRuntime.Constants.objectPathIdPrivate] > 0) {
                                propValue = this.getResolvedObjectFromObjectPathId(propValue[WacRuntime.Constants.objectPathIdPrivate]);
                            }
                            else if (propTypeInfo) {
                                propValue = this.resolveEnumIntValueIfHasEnumType(propValue, propTypeInfo);
                            }
                            WacRuntime.UtilityInternal.invokePropertySet(this.m_context, complexTypeInfo, propInfo, obj, propValue, false);
                        }
                    }
                    return obj;
                }
                return value;
            };
            JsComRequestProcessor.prototype.resolveEnumIntValueIfHasEnumType = function (value, typeInfo) {
                if (Array.isArray(value) && typeInfo.arrayItemTypeInfo) {
                    var items = value;
                    for (var i = 0; i < items.length; i++) {
                        items[i] = this.resolveEnumIntValueIfHasEnumType(items[i], typeInfo.arrayItemTypeInfo);
                    }
                }
                else if (typeInfo.isEnum && typeof (value) === "string") {
                    value = typeInfo.getEnumFieldValue(value);
                }
                return value;
            };
            JsComRequestProcessor.prototype.collectObjectPathIdInfos = function (objectPathIdInfos, indices, value, referencedObjectId) {
                if (Array.isArray(referencedObjectId) && Array.isArray(value)) {
                    var referencedObjectIdArray = referencedObjectId;
                    var valueArray = value;
                    for (var i = 0; i < valueArray.length; i++) {
                        var itemIndices = [];
                        for (var j = 0; j < indices.length; j++) {
                            itemIndices.push(indices[j]);
                        }
                        itemIndices.push(i);
                        this.collectObjectPathIdInfos(objectPathIdInfos, itemIndices, valueArray[i], referencedObjectIdArray[i]);
                    }
                }
                else if (referencedObjectId > 0 && referencedObjectId === value) {
                    objectPathIdInfos.push({ objectPathId: referencedObjectId, indices: indices });
                }
            };
            JsComRequestProcessor.prototype.createGetObjectFromObjectPathIdAndStoreParameterArgFunc = function (objectPathId, args, indices) {
                var _this = this;
                return function () {
                    return _this.getObjectFromObjectPathId(objectPathId).then(function (obj) {
                        var value = args;
                        for (var i = 0; i < indices.length - 1; i++) {
                            value = value[indices[i]];
                        }
                        value[indices[indices.length - 1]] = obj;
                    });
                };
            };
            JsComRequestProcessor.prototype.writeTraceIds = function (writer) {
                if (this.m_traceIds.length > 0) {
                    writer.writeName(WacRuntime.Constants.traceIds);
                    writer.startArrayScope();
                    for (var i = 0; i < this.m_traceIds.length; i++) {
                        writer.writeValue(this.m_traceIds[i]);
                    }
                    writer.endScope();
                }
            };
            JsComRequestProcessor.prototype.tryGetQueryForType = function (recursiveQueryInfo, typeInfo, query) {
                var typeName = WacRuntime.UtilityInternal.getShortTypeName(typeInfo.name).toLowerCase();
                var queryInfo = recursiveQueryInfo.Queries[typeName];
                if (WacRuntime.Utility.isNullOrUndefined(queryInfo)) {
                    if (!WacRuntime.Utility.isNullOrEmptyString(typeInfo.childItemTypeName)) {
                        typeName = WacRuntime.UtilityInternal.getShortTypeName(typeInfo.childItemTypeName).toLowerCase();
                        queryInfo = recursiveQueryInfo.Queries[typeName];
                    }
                }
                if (queryInfo) {
                    query.init(queryInfo.Select, queryInfo.Expand, queryInfo.Top, queryInfo.Skip);
                    return true;
                }
                return false;
            };
            JsComRequestProcessor.prototype.writeQueryResult = function (writer, query, obj, typeInfo, index, recursiveQueryInfo, recursiveDepth, donotKeepReference) {
                var _this = this;
                writer.startObjectScope();
                if (index >= 0) {
                    writer.writeName(WacRuntime.Constants.index);
                    writer.writeValue(index);
                }
                var p = WacRuntime.Utility.createPromiseFromResult(null);
                p = p.then(function () {
                    return _this.invokeKeepReferenceIfNecessary(donotKeepReference, obj);
                });
                var getItemAtMethod = typeInfo.tryGetItemAtMethod();
                if (typeInfo.supportEnumeration) {
                    p = p.then(function () {
                        return _this.writeScalarProperties(writer, query, obj, typeInfo, true);
                    });
                    p = p.then(function () {
                        return _this.writeChildItemsUsingEnumerator(writer, query, obj, typeInfo, recursiveQueryInfo, recursiveDepth, donotKeepReference);
                    });
                }
                else if (getItemAtMethod) {
                    p = p.then(function () {
                        return _this.writeScalarProperties(writer, query, obj, typeInfo, true);
                    });
                    p = p.then(function () {
                        return _this.writeChildItemsUsingGetItemAt(writer, query, obj, typeInfo, getItemAtMethod, recursiveQueryInfo, recursiveDepth, donotKeepReference);
                    });
                }
                else {
                    p = p.then(function () {
                        return _this.writeScalarProperties(writer, query, obj, typeInfo, false);
                    });
                    if (recursiveQueryInfo === null ||
                        recursiveDepth < recursiveQueryInfo.MaxDepth) {
                        p = p.then(function () {
                            return _this.writeNavigationProperties(writer, query, typeInfo, obj, recursiveQueryInfo, recursiveDepth + 1, donotKeepReference);
                        });
                    }
                }
                return p.then(function () {
                    writer.endScope();
                });
            };
            JsComRequestProcessor.prototype.writeScalarProperties = function (writer, query, obj, typeInfo, alwaysUseAllScalarProperties) {
                var p = WacRuntime.Utility.createPromiseFromResult(null);
                for (var name in typeInfo.properties) {
                    var propInfo = typeInfo.properties[name];
                    if (propInfo.propertyTypeCategory == WacRuntime.TypeCategory.primitive ||
                        propInfo.propertyTypeCategory == WacRuntime.TypeCategory.valueObject) {
                        if (alwaysUseAllScalarProperties || query.shouldSelectProperty(propInfo.lowerCaseName, propInfo.excludedFromDefaultLoad)) {
                            var propTypeInfo = this.m_context.typeReg.tryGetType(propInfo.propertyTypeName);
                            var func = this.createWriteScalarOnePropertyFunc(writer, typeInfo, propInfo, obj, propTypeInfo);
                            p = p.then(func);
                        }
                    }
                }
                return p;
            };
            JsComRequestProcessor.prototype.createWriteScalarOnePropertyFunc = function (writer, typeInfo, propInfo, obj, propTypeInfo) {
                var _this = this;
                return function () {
                    return WacRuntime.UtilityInternal.invokePropertyGetAsync(_this.m_context, typeInfo, propInfo, obj).then(function (propValue) {
                        writer.writeName(propInfo.name);
                        WacRuntime.UtilityInternal.writeValue(writer, _this.m_context, propTypeInfo, propValue);
                    });
                };
            };
            JsComRequestProcessor.prototype.writeNavigationProperties = function (writer, query, typeInfo, obj, recursiveQueryInfo, recursiveDepth, donotKeepReference) {
                var p = WacRuntime.Utility.createPromiseFromResult(null);
                for (var name in typeInfo.properties) {
                    var propInfo = typeInfo.properties[name];
                    if (propInfo.propertyTypeCategory == WacRuntime.TypeCategory.classObject) {
                        if (query.shouldExpandProperty(propInfo.lowerCaseName)) {
                            var propTypeInfo = this.m_context.typeReg.getType(propInfo.propertyTypeName);
                            var subQuery;
                            if (recursiveQueryInfo) {
                                subQuery = new WacRuntime.RESTfulQuery();
                                if (!this.tryGetQueryForType(recursiveQueryInfo, propTypeInfo, subQuery)) {
                                    subQuery = query.createQueryForProperty(propInfo.lowerCaseName);
                                }
                            }
                            else {
                                subQuery = query.createQueryForProperty(propInfo.lowerCaseName);
                            }
                            var func = this.createWiteNavigationOnePropertyFunc(writer, typeInfo, propInfo, obj, subQuery, propTypeInfo, recursiveQueryInfo, recursiveDepth, donotKeepReference);
                            p = p.then(func);
                        }
                    }
                }
                return p;
            };
            JsComRequestProcessor.prototype.createWiteNavigationOnePropertyFunc = function (writer, typeInfo, propInfo, obj, subQuery, propTypeInfo, recursiveQueryInfo, recursiveDepth, donotKeepReference) {
                var _this = this;
                return function () {
                    return WacRuntime.UtilityInternal.invokePropertyGetAsync(_this.m_context, typeInfo, propInfo, obj).then(function (propValue) {
                        writer.writeName(propInfo.name);
                        if (WacRuntime.Utility.isNullOrUndefined(propValue)) {
                            writer.writeValueNull();
                        }
                        else {
                            return _this.writeQueryResult(writer, subQuery, propValue, propTypeInfo, -1, recursiveQueryInfo, recursiveDepth, donotKeepReference);
                        }
                    });
                };
            };
            JsComRequestProcessor.prototype.writeChildItemsUsingEnumerator = function (writer, query, obj, typeInfo, recursiveQueryInfo, recursiveDepth, donotKeepReference) {
                var _this = this;
                var skip = 0;
                if (query.skip > 0) {
                    skip = query.skip;
                }
                var top = 0;
                if (query.top > 0) {
                    top = query.top;
                }
                return WacRuntime.UtilityInternal.invokeGetAsyncEnumerator(this.m_context, typeInfo, obj, skip, top)
                    .then(function (enu) {
                    var itemTypeInfo = _this.m_context.typeReg.getType(typeInfo.childItemTypeName);
                    var index = skip;
                    var end = 0;
                    if (top > 0) {
                        end = skip + top;
                    }
                    writer.writeName(WacRuntime.Constants.items);
                    writer.startArrayScope();
                    var p = _this.enumeratorLoop(enu, index, end, function (item, itemIndex) {
                        if (WacRuntime.Utility.isNullOrUndefined(item)) {
                            writer.writeValueNull();
                            return WacRuntime.Utility.createPromiseFromResult(null);
                        }
                        else {
                            return _this.writeQueryResult(writer, query, item, itemTypeInfo, itemIndex, recursiveQueryInfo, recursiveDepth, donotKeepReference);
                        }
                    });
                    p = p.then(function () {
                        writer.endScope();
                    });
                    return p;
                });
            };
            JsComRequestProcessor.prototype.enumeratorLoop = function (enu, index, end, fun) {
                var _this = this;
                if (end === 0 || index < end) {
                    return enu.moveNext().then(function (hasNext) {
                        if (hasNext) {
                            return fun(enu.get_current(), index).then(function () {
                                return _this.enumeratorLoop(enu, index + 1, end, fun);
                            });
                        }
                        else {
                            return WacRuntime.Utility.createPromiseFromResult(null);
                        }
                    });
                }
                else {
                    return WacRuntime.Utility.createPromiseFromResult(null);
                }
            };
            JsComRequestProcessor.prototype.writeChildItemsUsingGetItemAt = function (writer, query, obj, typeInfo, itemAtMethodInfo, recursiveQueryInfo, recursiveDepth, donotKeepReference) {
                var _this = this;
                var itemTypeInfo = this.m_context.typeReg.getType(itemAtMethodInfo.returnTypeName);
                var countPropInfo = typeInfo.tryGetProperty(WacRuntime.Constants.count);
                var getCountMethodInfo = typeInfo.tryGetMethod(WacRuntime.Constants.getCount);
                if (!countPropInfo && !getCountMethodInfo) {
                    return WacRuntime.Utility.createPromiseFromResult(null);
                }
                var countPromise;
                if (countPropInfo) {
                    countPromise = WacRuntime.UtilityInternal.invokePropertyGetAsync(this.m_context, typeInfo, countPropInfo, obj);
                }
                else {
                    countPromise = WacRuntime.UtilityInternal.invokeMethodAsync(this.m_context, typeInfo, getCountMethodInfo, obj, []);
                }
                return countPromise.then(function (count) {
                    var start = 0;
                    if (query.skip > 0) {
                        start = query.skip;
                    }
                    var end = count;
                    if (query.top > 0) {
                        end = start + query.top;
                        if (end > count) {
                            end = count;
                        }
                    }
                    writer.writeName(WacRuntime.Constants.items);
                    writer.startArrayScope();
                    return _this.getItemAtLoop(typeInfo, itemAtMethodInfo, obj, start, end, function (item, itemIndex) {
                        if (WacRuntime.Utility.isNullOrUndefined(item)) {
                            writer.writeValueNull();
                            return WacRuntime.Utility.createPromiseFromResult(null);
                        }
                        else {
                            return _this.writeQueryResult(writer, query, item, itemTypeInfo, itemIndex, recursiveQueryInfo, recursiveDepth, donotKeepReference);
                        }
                    }).then(function () {
                        writer.endScope();
                    });
                });
            };
            JsComRequestProcessor.prototype.getItemAtLoop = function (typeInfo, itemAtMethodInfo, obj, index, end, func) {
                var _this = this;
                if (index < end) {
                    return WacRuntime.UtilityInternal.invokeMethodAsync(this.m_context, typeInfo, itemAtMethodInfo, obj, [index])
                        .then(function (item) {
                        return func(item, index);
                    }).then(function () {
                        return _this.getItemAtLoop(typeInfo, itemAtMethodInfo, obj, index + 1, end, func);
                    });
                }
                else {
                    return WacRuntime.Utility.createPromiseFromResult(null);
                }
            };
            JsComRequestProcessor.prototype.invokeOnAccess = function (obj) {
                if (obj) {
                    var typeInfo = this.m_context.typeReg.getType(obj.getTypeName());
                    var methodInfo = typeInfo.tryGetMethod(WacRuntime.Constants.onAccess);
                    if (methodInfo) {
                        return WacRuntime.UtilityInternal.invokeMethodAsync(this.m_context, typeInfo, methodInfo, obj, []).then(function () {
                            return obj;
                        });
                    }
                }
                return WacRuntime.Utility.createPromiseFromResult(obj);
            };
            JsComRequestProcessor.prototype.invokeKeepReferenceIfNecessary = function (donotKeepReference, obj) {
                if (!donotKeepReference &&
                    obj &&
                    obj !== this.m_context.request.globalObject &&
                    this.m_requestMessage.AutoKeepReference) {
                    var typeInfo = this.m_context.typeReg.getType(obj.getTypeName());
                    var methodInfo = typeInfo.tryGetMethod(WacRuntime.Constants.keepReference);
                    if (methodInfo) {
                        return WacRuntime.UtilityInternal.invokeMethodAsync(this.m_context, typeInfo, methodInfo, obj, []).then(function () {
                            return obj;
                        });
                    }
                }
                return WacRuntime.Utility.createPromiseFromResult(obj);
            };
            JsComRequestProcessor.s_regexISODate = /^(\d{4})-(\d{2})-(\d{2})T(\d{2}):(\d{2}):(\d{2})(\.\d+)?(([+-]\d\d:\d\d)|Z)?$/;
            return JsComRequestProcessor;
        }());
        WacRuntime.JsComRequestProcessor = JsComRequestProcessor;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var JsonWriter = (function () {
            function JsonWriter() {
                this.m_scopes = [];
            }
            JsonWriter.prototype.startScope = function (scopeType) {
                var scope;
                if (scopeType == 0) {
                    scope = {
                        scopeType: scopeType,
                        object: {}
                    };
                }
                else {
                    scope = {
                        scopeType: scopeType,
                        object: []
                    };
                }
                if (this.m_scopes.length > 0) {
                    var value = scope.object;
                    if (this.m_scopes[this.m_scopes.length - 1].scopeType == 1) {
                        this.m_scopes[this.m_scopes.length - 1].object.push(value);
                    }
                    else {
                        if (WacRuntime.Utility.isNullOrEmptyString(this.m_pendingPropertyName)) {
                            throw WacRuntime.Utility.createInvalidOperationException();
                        }
                        this.m_scopes[this.m_scopes.length - 1].object[this.m_pendingPropertyName] = value;
                        this.m_pendingPropertyName = null;
                    }
                }
                this.m_scopes.push(scope);
                if (WacRuntime.Utility.isNullOrUndefined(this.m_firstScope)) {
                    this.m_firstScope = scope;
                }
            };
            JsonWriter.prototype.endScope = function () {
                this.m_scopes.splice(this.m_scopes.length - 1);
            };
            JsonWriter.prototype.startArrayScope = function () {
                this.startScope(1);
            };
            JsonWriter.prototype.startObjectScope = function () {
                this.startScope(0);
            };
            JsonWriter.prototype.writeName = function (name) {
                if (this.m_scopes.length < 1 || this.m_scopes[this.m_scopes.length - 1].scopeType != 0) {
                    throw WacRuntime.Utility.createInvalidOperationException();
                }
                if (!WacRuntime.Utility.isNullOrEmptyString(this.m_pendingPropertyName)) {
                    throw WacRuntime.Utility.createInvalidOperationException();
                }
                this.m_pendingPropertyName = name;
            };
            JsonWriter.prototype.writeValue = function (value) {
                if (WacRuntime.Utility.isNullOrUndefined(value)) {
                    value = null;
                }
                if (this.m_scopes.length < 1) {
                    throw WacRuntime.Utility.createInvalidOperationException();
                }
                if (this.m_scopes[this.m_scopes.length - 1].scopeType == 1) {
                    this.m_scopes[this.m_scopes.length - 1].object.push(value);
                }
                else {
                    if (WacRuntime.Utility.isNullOrEmptyString(this.m_pendingPropertyName)) {
                        throw WacRuntime.Utility.createInvalidOperationException();
                    }
                    this.m_scopes[this.m_scopes.length - 1].object[this.m_pendingPropertyName] = value;
                    this.m_pendingPropertyName = null;
                }
            };
            JsonWriter.prototype.writeValueNull = function () {
                this.writeValue(null);
            };
            JsonWriter.prototype.writeRawValueFrom = function (writer) {
                this.writeValue(writer.m_firstScope.object);
            };
            JsonWriter.prototype.getJsonString = function () {
                if (this.m_firstScope) {
                    return JSON.stringify(this.m_firstScope.object);
                }
                else {
                    return "";
                }
            };
            Object.defineProperty(JsonWriter.prototype, "isEmpty", {
                get: function () {
                    if (this.m_firstScope) {
                        return false;
                    }
                    return true;
                },
                enumerable: true,
                configurable: true
            });
            return JsonWriter;
        }());
        WacRuntime.JsonWriter = JsonWriter;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var MethodInformation = (function () {
            function MethodInformation(parentTypeName, name, dispatchId, returnTypeName, returnTypeCategory, operationType, apiFlags) {
                this.m_name = name;
                this.m_dispatchId = dispatchId;
                this.m_returnTypeName = returnTypeName;
                this.m_returnTypeCategory = returnTypeCategory;
                this.m_operationType = operationType;
                this.m_parameters = [];
                this.m_apiName = WacRuntime.UtilityInternal.getApiName(parentTypeName, name);
                this.m_apiFlags = apiFlags;
            }
            Object.defineProperty(MethodInformation.prototype, "name", {
                get: function () {
                    return this.m_name;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(MethodInformation.prototype, "returnTypeCategory", {
                get: function () {
                    return this.m_returnTypeCategory;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(MethodInformation.prototype, "returnTypeName", {
                get: function () {
                    return this.m_returnTypeName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(MethodInformation.prototype, "dispatchId", {
                get: function () {
                    return this.m_dispatchId;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(MethodInformation.prototype, "methodOperationType", {
                get: function () {
                    return this.m_operationType;
                },
                enumerable: true,
                configurable: true
            });
            MethodInformation.prototype.addParameter = function (name, parameterTypeName, parameterTypeCategory, knownTypeName, apiFlags) {
                var par = new WacRuntime.ParameterInformation(name, parameterTypeName, parameterTypeCategory, knownTypeName, apiFlags);
                this.m_parameters.push(par);
                return par;
            };
            Object.defineProperty(MethodInformation.prototype, "parameters", {
                get: function () {
                    return this.m_parameters;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(MethodInformation.prototype, "apiName", {
                get: function () {
                    return this.m_apiName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(MethodInformation.prototype, "apiFlags", {
                get: function () {
                    return this.m_apiFlags;
                },
                enumerable: true,
                configurable: true
            });
            return MethodInformation;
        }());
        WacRuntime.MethodInformation = MethodInformation;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var OperationType;
        (function (OperationType) {
            OperationType[OperationType["defaultValue"] = 0] = "defaultValue";
            OperationType[OperationType["read"] = 1] = "read";
        })(OperationType = WacRuntime.OperationType || (WacRuntime.OperationType = {}));
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var ParameterInformation = (function () {
            function ParameterInformation(name, typeName, typeCategory, knownTypeName, apiFlags) {
                this.m_name = name;
                this.m_typeName = typeName;
                this.m_typeCategory = typeCategory;
                if (WacRuntime.Utility.isNullOrUndefined(apiFlags)) {
                    apiFlags = WacRuntime.ApiFlags.none;
                }
                this.m_apiFlags = apiFlags;
                if (this.m_typeCategory === WacRuntime.TypeCategory.primitive) {
                    this.m_fallbackComplexTypeName = knownTypeName;
                }
                else if (this.m_typeCategory === WacRuntime.TypeCategory.valueObject) {
                    this.m_fallbackComplexTypeName = WacRuntime.UtilityInternal.getTypeNameWithoutArraySuffix(typeName);
                }
            }
            Object.defineProperty(ParameterInformation.prototype, "name", {
                get: function () {
                    return this.m_name;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(ParameterInformation.prototype, "parameterTypeName", {
                get: function () {
                    return this.m_typeName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(ParameterInformation.prototype, "parameterTypeCategory", {
                get: function () {
                    return this.m_typeCategory;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(ParameterInformation.prototype, "fallbackComplexTypeName", {
                get: function () {
                    return this.m_fallbackComplexTypeName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(ParameterInformation.prototype, "apiFlags", {
                get: function () {
                    return this.m_apiFlags;
                },
                enumerable: true,
                configurable: true
            });
            return ParameterInformation;
        }());
        WacRuntime.ParameterInformation = ParameterInformation;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var PreviewExecutionRegistration = (function () {
            function PreviewExecutionRegistration() {
                this.m_maps = {};
            }
            PreviewExecutionRegistration.prototype.add = function (typeName, methodName, func) {
                var type = this.m_maps[typeName];
                if (!type) {
                    type = {};
                    this.m_maps[typeName] = type;
                }
                type[methodName] = func;
            };
            PreviewExecutionRegistration.prototype.get = function (typeName, methodName) {
                var type = this.m_maps[typeName];
                if (!type) {
                    throw WacRuntime.Utility.createInvalidRequestException();
                }
                var ret = type[methodName];
                if (!ret) {
                    throw WacRuntime.Utility.createInvalidRequestException();
                }
                return ret;
            };
            return PreviewExecutionRegistration;
        }());
        WacRuntime.PreviewExecutionRegistration = PreviewExecutionRegistration;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var PreviewExecutor = (function () {
            function PreviewExecutor(context, buildRegistrationFunc, request) {
                this.m_context = context;
                this.m_request = new WacRuntime.RichApiRequest();
                this.m_request.init(request, null);
                if (this.m_request.requestType == 0) {
                    var requestMessage = JSON.parse(this.m_request.body);
                    this.m_previewExecutionActions = requestMessage.PreviewExecutionActions;
                    delete requestMessage.PreviewExecutionActions;
                    request[4] = JSON.stringify(requestMessage);
                }
                if (!PreviewExecutor.s_registration) {
                    PreviewExecutor.s_registration = new WacRuntime.PreviewExecutionRegistration();
                    buildRegistrationFunc(PreviewExecutor.s_registration);
                }
            }
            PreviewExecutor.prototype.process = function () {
                var promise = WacRuntime.Utility.createPromiseFromResult(null);
                if (this.m_request.requestType != 0) {
                    return promise;
                }
                if (!this.m_previewExecutionActions) {
                    return promise;
                }
                for (var i = 0; i < this.m_previewExecutionActions.length; i++) {
                    var action = this.m_previewExecutionActions[i];
                    var objectId = action.ObjectId;
                    if (typeof (objectId) === 'number') {
                        objectId = objectId.toString();
                    }
                    if (action.ActionType === 3) {
                        var method = PreviewExecutor.s_registration.get(action.ObjectType, action.Name);
                        var args = [this.m_context, action.ObjectId].concat(action.Arguments);
                        promise = promise.then(function () {
                            return method.apply(null, args);
                        });
                    }
                    else if (action.ActionType === 4) {
                        var method = PreviewExecutor.s_registration.get(action.ObjectType, "Set" + action.Name);
                        var args = [this.m_context, action.ObjectId].concat(action.Arguments);
                        promise = promise.then(function () {
                            return method.apply(null, args);
                        });
                    }
                }
                return promise;
            };
            return PreviewExecutor;
        }());
        WacRuntime.PreviewExecutor = PreviewExecutor;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var PropertyInformation = (function () {
            function PropertyInformation(parentTypeName, name, dispatchId, propertyTypeName, propertyTypeCategory, isReadonly, knownTypeName, apiFlags) {
                this.m_name = name;
                this.m_dispatchId = dispatchId;
                this.m_propertyTypeName = propertyTypeName;
                this.m_propertyTypeCategory = propertyTypeCategory;
                this.m_isReadonly = isReadonly;
                this.m_parameters = [];
                this.m_parameters.push(new WacRuntime.ParameterInformation("value", propertyTypeName, propertyTypeCategory, knownTypeName, apiFlags));
                this.m_apiName = WacRuntime.UtilityInternal.getApiName(parentTypeName, name);
                this.m_lowerCaseName = name.toLowerCase();
                this.m_camelLowerCaseName = WacRuntime.UtilityInternal.toCamelLowerCase(name);
                if (this.m_propertyTypeCategory === WacRuntime.TypeCategory.primitive) {
                    this.m_fallbackComplexTypeName = knownTypeName;
                }
                else if (this.m_propertyTypeCategory === WacRuntime.TypeCategory.valueObject) {
                    this.m_fallbackComplexTypeName = WacRuntime.UtilityInternal.getTypeNameWithoutArraySuffix(propertyTypeName);
                }
                this.m_apiFlags = apiFlags;
            }
            Object.defineProperty(PropertyInformation.prototype, "name", {
                get: function () {
                    return this.m_name;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "lowerCaseName", {
                get: function () {
                    return this.m_lowerCaseName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "camelLowerCaseName", {
                get: function () {
                    return this.m_camelLowerCaseName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "propertyTypeCategory", {
                get: function () {
                    return this.m_propertyTypeCategory;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "propertyTypeName", {
                get: function () {
                    return this.m_propertyTypeName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "isReadonly", {
                get: function () {
                    return this.m_isReadonly;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "fallbackComplexTypeName", {
                get: function () {
                    return this.m_fallbackComplexTypeName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "dispatchId", {
                get: function () {
                    return this.m_dispatchId;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "parameters", {
                get: function () {
                    return this.m_parameters;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "apiName", {
                get: function () {
                    return this.m_apiName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "apiFlags", {
                get: function () {
                    return this.m_apiFlags;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(PropertyInformation.prototype, "excludedFromDefaultLoad", {
                get: function () {
                    return ((this.m_apiFlags & WacRuntime.ApiFlags.excludedFromDefaultLoad) !== 0);
                },
                enumerable: true,
                configurable: true
            });
            return PropertyInformation;
        }());
        WacRuntime.PropertyInformation = PropertyInformation;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var ResourceStrings = (function () {
            function ResourceStrings() {
            }
            ResourceStrings.accessDenied = "AccessDenied";
            ResourceStrings.apiNotFound = "ApiNotFound";
            ResourceStrings.invalidArgument = "InvalidArgument";
            ResourceStrings.invalidOperation = "InvalidOperation";
            ResourceStrings.invalidRequest = "InvalidRequest";
            return ResourceStrings;
        }());
        WacRuntime.ResourceStrings = ResourceStrings;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var RESTfulQuery = (function () {
            function RESTfulQuery() {
                this.m_select = new WacRuntime.SelectExpandQuery();
                this.m_expand = new WacRuntime.SelectExpandQuery();
                this.m_top = 0;
                this.m_skip = 0;
            }
            Object.defineProperty(RESTfulQuery.prototype, "top", {
                get: function () {
                    return this.m_top;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RESTfulQuery.prototype, "skip", {
                get: function () {
                    return this.m_skip;
                },
                enumerable: true,
                configurable: true
            });
            RESTfulQuery.prototype.init = function (select, expand, top, skip) {
                this.m_select.init(true, select);
                this.m_expand.init(false, expand);
                this.m_top = top;
                this.m_skip = skip;
            };
            RESTfulQuery.prototype.shouldSelectProperty = function (propName, excludedFromDefaultLoad) {
                if ((this.m_select.isEmpty || this.m_select.hasWildcard) &&
                    !excludedFromDefaultLoad) {
                    return true;
                }
                if (this.m_select.properties[propName]) {
                    return true;
                }
                if (this.m_expand.properties[propName]) {
                    return true;
                }
                if (propName == WacRuntime.Constants.idLowerCase ||
                    propName == WacRuntime.Constants.idPrivateLowerCase ||
                    propName == WacRuntime.Constants.referenceIdLowerCase) {
                    return true;
                }
                return false;
            };
            RESTfulQuery.prototype.shouldExpandProperty = function (propName) {
                if (this.shouldSelectProperty(propName, false) &&
                    (this.m_expand.properties[propName] || this.m_select.properties[propName])) {
                    return true;
                }
                return false;
            };
            RESTfulQuery.prototype.createQueryForProperty = function (propName) {
                var ret = new RESTfulQuery();
                if (this.m_select.properties[propName]) {
                    ret.m_select = this.m_select.properties[propName];
                }
                if (this.m_expand.properties[propName]) {
                    ret.m_expand = this.m_expand.properties[propName];
                }
                return ret;
            };
            return RESTfulQuery;
        }());
        WacRuntime.RESTfulQuery = RESTfulQuery;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var RichApi = (function () {
            function RichApi() {
            }
            RichApi.executeRichApiRequest = function (richApiHost, typeRegFunc, globalObject, request) {
                if (!RichApi.s_typeReg) {
                    var typeReg = new WacRuntime.TypeRegistration();
                    if (typeRegFunc) {
                        typeRegFunc(typeReg);
                    }
                    typeReg.addAuxEnumTypes();
                    RichApi.s_typeReg = typeReg;
                }
                var context = new WacRuntime.RichApiRequestContext(RichApi.s_typeReg, richApiHost);
                context.request.init(request, globalObject);
                var ret = WacRuntime.Utility.createPromiseFromResult(null);
                if (context.request.requestType == 0) {
                    var processor = new WacRuntime.JsComRequestProcessor(context);
                    ret = processor.process();
                }
                return ret.then(function () {
                    return WacRuntime.Utility.createPromiseFromResult(context.response.toArrayData());
                });
            };
            RichApi.initEventManagerHost = function (host) {
                if (!RichApi.s_eventManager) {
                    RichApi.s_eventManager = new WacRuntime.EventManager();
                }
                RichApi.s_eventManager.initHost(host);
            };
            RichApi.getEventManager = function () {
                if (!RichApi.s_eventManager) {
                    RichApi.s_eventManager = new WacRuntime.EventManager();
                }
                return RichApi.s_eventManager;
            };
            RichApi.previewExecute = function (context, buildRegistrationFunc, request) {
                var executor = new WacRuntime.PreviewExecutor(context, buildRegistrationFunc, request);
                return executor.process();
            };
            return RichApi;
        }());
        WacRuntime.RichApi = RichApi;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var RichApiException = (function (_super) {
            __extends(RichApiException, _super);
            function RichApiException(code, message, httpStatusCode, location) {
                var _this = _super.call(this, message) || this;
                Object.setPrototypeOf(_this, RichApiException.prototype);
                _this.name = "OfficeExtension.WacRuntime.RichApiException";
                _this.code = code;
                _this.message = message;
                _this.httpStatusCode = httpStatusCode;
                _this.location = location;
                return _this;
            }
            return RichApiException;
        }(Error));
        WacRuntime.RichApiException = RichApiException;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var RichApiRequest = (function () {
            function RichApiRequest() {
            }
            RichApiRequest.prototype.init = function (request, globalObject) {
                this.m_globalObject = globalObject;
                this.m_method = request[1];
                var pathAndQuery = request[2];
                var index = pathAndQuery.indexOf('?');
                if (index >= 0) {
                    this.m_path = pathAndQuery.substr(0, index);
                    this.m_query = pathAndQuery.substr(index + 1);
                }
                else {
                    this.m_path = pathAndQuery;
                    this.m_query = "";
                }
                if (this.m_method == WacRuntime.Constants.httpMethodPost && this.m_path == WacRuntime.Constants.processQuery) {
                    this.m_requestType = 0;
                }
                else {
                    this.m_requestType = 1;
                }
                this.m_body = request[4];
                this.m_requestFlags = request[6];
            };
            Object.defineProperty(RichApiRequest.prototype, "requestType", {
                get: function () {
                    return this.m_requestType;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequest.prototype, "method", {
                get: function () {
                    return this.m_method;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequest.prototype, "path", {
                get: function () {
                    return this.m_path;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequest.prototype, "query", {
                get: function () {
                    return this.m_query;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequest.prototype, "body", {
                get: function () {
                    return this.m_body;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequest.prototype, "requestFlags", {
                get: function () {
                    return this.m_requestFlags;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequest.prototype, "globalObject", {
                get: function () {
                    return this.m_globalObject;
                },
                enumerable: true,
                configurable: true
            });
            return RichApiRequest;
        }());
        WacRuntime.RichApiRequest = RichApiRequest;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var SimpleRichApiHost = (function () {
            function SimpleRichApiHost() {
            }
            SimpleRichApiHost.prototype.hostName = function () {
                return "";
            };
            SimpleRichApiHost.prototype.appId = function () {
                return "";
            };
            SimpleRichApiHost.prototype.createInstance = function (typeName) {
                throw WacRuntime.Utility.createInvalidRequestException();
            };
            return SimpleRichApiHost;
        }());
        var RichApiRequestContext = (function () {
            function RichApiRequestContext(typeReg, richApiHost) {
                this.m_typeReg = typeReg;
                this.m_request = new WacRuntime.RichApiRequest();
                this.m_response = new WacRuntime.RichApiResponse();
                if (!richApiHost) {
                    richApiHost = new SimpleRichApiHost();
                }
                this.m_richApiHost = richApiHost;
            }
            Object.defineProperty(RichApiRequestContext.prototype, "request", {
                get: function () {
                    return this.m_request;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequestContext.prototype, "response", {
                get: function () {
                    return this.m_response;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequestContext.prototype, "typeReg", {
                get: function () {
                    return this.m_typeReg;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(RichApiRequestContext.prototype, "host", {
                get: function () {
                    return this.m_richApiHost;
                },
                enumerable: true,
                configurable: true
            });
            return RichApiRequestContext;
        }());
        WacRuntime.RichApiRequestContext = RichApiRequestContext;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var RichApiRequestFlags;
        (function (RichApiRequestFlags) {
            RichApiRequestFlags[RichApiRequestFlags["None"] = 0] = "None";
            RichApiRequestFlags[RichApiRequestFlags["WriteOperation"] = 1] = "WriteOperation";
            RichApiRequestFlags[RichApiRequestFlags["RestrictedResourceAccess"] = 2] = "RestrictedResourceAccess";
            RichApiRequestFlags[RichApiRequestFlags["Concurrent"] = 4] = "Concurrent";
            RichApiRequestFlags[RichApiRequestFlags["ConcurrentCheck"] = 8] = "ConcurrentCheck";
            RichApiRequestFlags[RichApiRequestFlags["Undoable"] = 16] = "Undoable";
            RichApiRequestFlags[RichApiRequestFlags["UndoableCheck"] = 32] = "UndoableCheck";
            RichApiRequestFlags[RichApiRequestFlags["DelayForCellEdit"] = 64] = "DelayForCellEdit";
            RichApiRequestFlags[RichApiRequestFlags["UndoPreviewEnabled"] = 128] = "UndoPreviewEnabled";
            RichApiRequestFlags[RichApiRequestFlags["DoesNotMakeContentDirty"] = 256] = "DoesNotMakeContentDirty";
            RichApiRequestFlags[RichApiRequestFlags["OnlyAllowCallableWithoutPermissionApi"] = 512] = "OnlyAllowCallableWithoutPermissionApi";
            RichApiRequestFlags[RichApiRequestFlags["OnlyAllowMakerSafeApi"] = 1024] = "OnlyAllowMakerSafeApi";
            RichApiRequestFlags[RichApiRequestFlags["DonotShowSavingState"] = 2048] = "DonotShowSavingState";
            RichApiRequestFlags[RichApiRequestFlags["PreviewExecution"] = 4096] = "PreviewExecution";
        })(RichApiRequestFlags = WacRuntime.RichApiRequestFlags || (WacRuntime.RichApiRequestFlags = {}));
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var RichApiResponse = (function () {
            function RichApiResponse() {
                this.m_writer = new WacRuntime.JsonWriter();
            }
            RichApiResponse.prototype.reset = function () {
                var ret = this.m_writer;
                this.m_writer = new WacRuntime.JsonWriter();
                return ret;
            };
            Object.defineProperty(RichApiResponse.prototype, "writer", {
                get: function () {
                    return this.m_writer;
                },
                enumerable: true,
                configurable: true
            });
            RichApiResponse.prototype.toArrayData = function () {
                var ret = [];
                ret[0] = 200;
                ret[1] = null;
                ret[2] = this.m_writer.getJsonString();
                return ret;
            };
            return RichApiResponse;
        }());
        WacRuntime.RichApiResponse = RichApiResponse;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var SelectExpandQuery = (function () {
            function SelectExpandQuery() {
                this.m_hasWildcard = false;
                this.m_properties = {};
            }
            Object.defineProperty(SelectExpandQuery.prototype, "hasWildcard", {
                get: function () {
                    return this.m_hasWildcard;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(SelectExpandQuery.prototype, "isEmpty", {
                get: function () {
                    var ret = true;
                    for (var name in this.m_properties) {
                        ret = false;
                        break;
                    }
                    return ret;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(SelectExpandQuery.prototype, "properties", {
                get: function () {
                    return this.m_properties;
                },
                enumerable: true,
                configurable: true
            });
            SelectExpandQuery.prototype.init = function (allowWildcard, selectsOrExpands) {
                if (selectsOrExpands) {
                    for (var i = 0; i < selectsOrExpands.length; i++) {
                        var currentQuery = this;
                        var propNames = selectsOrExpands[i].split("/");
                        for (var j = 0; j < propNames.length; j++) {
                            var propName = propNames[j];
                            propName = propName.trim().toLowerCase();
                            if (propName == "*") {
                                if (!allowWildcard) {
                                    throw WacRuntime.Utility.createInvalidRequestException();
                                }
                                currentQuery.m_hasWildcard = true;
                            }
                            else {
                                var subQuery = currentQuery.m_properties[propName];
                                if (!subQuery) {
                                    subQuery = new SelectExpandQuery();
                                    currentQuery.m_properties[propName] = subQuery;
                                }
                                currentQuery = subQuery;
                            }
                        }
                    }
                }
            };
            return SelectExpandQuery;
        }());
        WacRuntime.SelectExpandQuery = SelectExpandQuery;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var Settings = (function () {
            function Settings() {
            }
            return Settings;
        }());
        WacRuntime.Settings = Settings;
        WacRuntime.settings = new Settings;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var Logger = (function () {
            function Logger() {
            }
            Logger.SendULSTraceTag = function (data, hostName, level, tagId) {
                if (!window.Microsoft || !Microsoft.Office || !Microsoft.Office.WebExtension || !Microsoft.Office.WebExtension.FULSSupported) {
                    return;
                }
                var category = 1403;
                if (hostName == "WordOnline") {
                    category = 369;
                }
                else if (hostName == "OneNoteOnline") {
                    category = 372;
                }
                else {
                    return;
                }
                if (window.Diag && Diag.UULS && Diag.UULS.trace) {
                    Diag.UULS.trace(tagId, category, level, data);
                }
            };
            return Logger;
        }());
        WacRuntime.Logger = Logger;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var TypeCategory;
        (function (TypeCategory) {
            TypeCategory[TypeCategory["none"] = 0] = "none";
            TypeCategory[TypeCategory["primitive"] = 1] = "primitive";
            TypeCategory[TypeCategory["valueObject"] = 2] = "valueObject";
            TypeCategory[TypeCategory["classObject"] = 3] = "classObject";
        })(TypeCategory = WacRuntime.TypeCategory || (WacRuntime.TypeCategory = {}));
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var TypeFlags;
        (function (TypeFlags) {
            TypeFlags[TypeFlags["none"] = 0] = "none";
            TypeFlags[TypeFlags["useItemAsIndexerNameInODataId"] = 1] = "useItemAsIndexerNameInODataId";
            TypeFlags[TypeFlags["restrictedResource"] = 2] = "restrictedResource";
            TypeFlags[TypeFlags["propertySetUndoable"] = 4] = "propertySetUndoable";
            TypeFlags[TypeFlags["shouldSkipUndefinedProperties"] = 8] = "shouldSkipUndefinedProperties";
            TypeFlags[TypeFlags["safeForCellEditMode"] = 16] = "safeForCellEditMode";
            TypeFlags[TypeFlags["propertySetDoesNotMakeContentDirty"] = 32] = "propertySetDoesNotMakeContentDirty";
            TypeFlags[TypeFlags["makerSafe"] = 64] = "makerSafe";
        })(TypeFlags = WacRuntime.TypeFlags || (WacRuntime.TypeFlags = {}));
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var TypeInformation = (function () {
            function TypeInformation(name, interfaceId, classId, isEnum, typeCategory, typeFlags) {
                this.m_name = name;
                this.m_interfaceId = interfaceId;
                this.m_classId = classId;
                this.m_properties = {};
                this.m_methods = {};
                this.m_enumFields = {};
                this.m_enumFieldLowerCaseNameToValue = {};
                this.m_enumFieldValueToName = {};
                this.m_isEnum = isEnum;
                if (WacRuntime.Utility.isNullOrUndefined(typeCategory)) {
                    typeCategory = WacRuntime.TypeCategory.classObject;
                }
                this.m_typeCategory = typeCategory;
                if (WacRuntime.Utility.isNullOrUndefined(typeFlags)) {
                    typeFlags = WacRuntime.TypeFlags.none;
                }
                this.m_typeFlags = typeFlags;
            }
            Object.defineProperty(TypeInformation.prototype, "name", {
                get: function () {
                    return this.m_name;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "isEnum", {
                get: function () {
                    return this.m_isEnum;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "isNullableEnum", {
                get: function () {
                    return this.m_isNullableEnum;
                },
                set: function (value) {
                    this.m_isNullableEnum = value;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "classId", {
                get: function () {
                    return this.m_classId;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "interfaceId", {
                get: function () {
                    return this.m_interfaceId;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "typeCategory", {
                get: function () {
                    return this.m_typeCategory;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "typeFlags", {
                get: function () {
                    return this.m_typeFlags;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "properties", {
                get: function () {
                    return this.m_properties;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "supportEnumeration", {
                get: function () {
                    return this.m_supportEnumeration;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "childItemTypeName", {
                get: function () {
                    return this.m_childItemTypeName;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "enumFields", {
                get: function () {
                    return this.m_enumFields;
                },
                enumerable: true,
                configurable: true
            });
            Object.defineProperty(TypeInformation.prototype, "arrayItemTypeInfo", {
                get: function () {
                    return this.m_arrayItemTypeInfo;
                },
                set: function (value) {
                    this.m_arrayItemTypeInfo = value;
                },
                enumerable: true,
                configurable: true
            });
            TypeInformation.prototype.addProperty = function (name, dispatchId, propertyTypeName, typeCategory, isReadonly, knownTypeName, apiFlags) {
                var prop = new WacRuntime.PropertyInformation(this.m_name, name, dispatchId, propertyTypeName, typeCategory, isReadonly, knownTypeName, apiFlags);
                this.m_properties[name.toLowerCase()] = prop;
                return prop;
            };
            TypeInformation.prototype.addMethod = function (name, dispatchId, returnTypeName, returnTypeCategory, operationType, restfulName, apiFlags) {
                var method = new WacRuntime.MethodInformation(this.m_name, name, dispatchId, returnTypeName, returnTypeCategory, operationType, apiFlags);
                this.m_methods[name.toLowerCase()] = method;
                return method;
            };
            TypeInformation.prototype.addIndexerMethod = function (dispatchId, returnTypeName, returnTypeCategory, apiFlags) {
                return this.addMethod(TypeInformation.s_indexerMethodName, dispatchId, returnTypeName, returnTypeCategory, WacRuntime.OperationType.read, null, apiFlags);
            };
            TypeInformation.prototype.addEnumField = function (name, value) {
                this.m_enumFields[name] = value;
                this.m_enumFieldLowerCaseNameToValue[name.toLowerCase()] = value;
                this.m_enumFieldValueToName[value] = name;
            };
            TypeInformation.prototype.setRESTfulOperationMethodNames = function (createItemOperatioName, deleteOperationName) {
                this.m_createItemOperationName = createItemOperatioName;
                this.m_deleteOperationName = deleteOperationName;
            };
            TypeInformation.prototype.setCollectionInfo = function (childItemTypeName, supportEnumeration) {
                this.m_childItemTypeName = childItemTypeName;
                this.m_supportEnumeration = supportEnumeration;
            };
            TypeInformation.prototype.tryGetIndexerMethod = function () {
                return this.tryGetMethod(TypeInformation.s_indexerMethodName);
            };
            TypeInformation.prototype.getIndexerMethod = function () {
                return this.getMethod(TypeInformation.s_indexerMethodName);
            };
            TypeInformation.prototype.getMethod = function (name) {
                var lowerCaseName = name.toLowerCase();
                var ret = this.m_methods[lowerCaseName];
                if (!ret) {
                    var apiName = WacRuntime.UtilityInternal.getApiName(this.m_name, name);
                    throw WacRuntime.Utility.createApiNotFoundException(apiName);
                }
                return ret;
            };
            TypeInformation.prototype.tryGetMethod = function (name) {
                name = name.toLowerCase();
                return this.m_methods[name];
            };
            TypeInformation.prototype.getProperty = function (name) {
                var lowerCaseName = name.toLowerCase();
                var ret = this.m_properties[lowerCaseName];
                if (!ret) {
                    var apiName = WacRuntime.UtilityInternal.getApiName(this.m_name, name);
                    throw WacRuntime.Utility.createApiNotFoundException(apiName);
                }
                return ret;
            };
            TypeInformation.prototype.tryGetProperty = function (name) {
                name = name.toLowerCase();
                return this.m_properties[name];
            };
            TypeInformation.prototype.getEnumFieldValue = function (name) {
                var ret = this.m_enumFieldLowerCaseNameToValue[name.toLowerCase()];
                if (WacRuntime.Utility.isUndefined(ret)) {
                    throw WacRuntime.Utility.createInvalidRequestException();
                }
                return ret;
            };
            TypeInformation.prototype.getEnumFieldName = function (value) {
                var ret = this.m_enumFieldValueToName[value];
                return ret;
            };
            TypeInformation.prototype.tryGetItemAtMethod = function () {
                return this.tryGetMethod(WacRuntime.Constants.getItemAt);
            };
            TypeInformation.s_indexerMethodName = ".indexer";
            return TypeInformation;
        }());
        WacRuntime.TypeInformation = TypeInformation;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var TypeRegistration = (function () {
            function TypeRegistration() {
                this.m_types = {};
            }
            TypeRegistration.prototype.getType = function (name) {
                var ret = this.m_types[name];
                if (!ret) {
                    throw WacRuntime.Utility.createInvalidRequestException();
                }
                return ret;
            };
            TypeRegistration.prototype.tryGetType = function (name) {
                var ret = this.m_types[name];
                return ret;
            };
            TypeRegistration.prototype.addType = function (name, interfaceId, classId, typeCategory, typeFlags) {
                var type = new WacRuntime.TypeInformation(name, interfaceId, classId, false, typeCategory, typeFlags);
                this.m_types[name] = type;
                return type;
            };
            TypeRegistration.prototype.addEnumType = function (name) {
                var type = new WacRuntime.TypeInformation(name, null, null, true, WacRuntime.TypeCategory.none, WacRuntime.TypeFlags.none);
                this.m_types[name] = type;
                return type;
            };
            TypeRegistration.prototype.addAuxEnumTypes = function () {
                var enumTypes = [];
                for (var typeName in this.m_types) {
                    var oneType = this.m_types[typeName];
                    if (oneType.isEnum && !oneType.isNullableEnum) {
                        enumTypes.push(oneType);
                    }
                }
                for (var i = 0; i < enumTypes.length; i++) {
                    var oneType = enumTypes[i];
                    var newTypeName = oneType.name;
                    newTypeName = newTypeName + WacRuntime.Constants.nullableTypeSuffix;
                    var newType = this.addEnumType(newTypeName);
                    newType.isNullableEnum = true;
                    for (var fieldName in oneType.enumFields) {
                        newType.addEnumField(fieldName, oneType.enumFields[fieldName]);
                    }
                    var arrayTypeName1D = oneType.name + WacRuntime.Constants.arrayTypeSufix;
                    var type1D = new WacRuntime.TypeInformation(arrayTypeName1D, null, null, false, WacRuntime.TypeCategory.none, WacRuntime.TypeFlags.none);
                    type1D.arrayItemTypeInfo = oneType;
                    this.m_types[arrayTypeName1D] = type1D;
                    var arrayTypeName2D = arrayTypeName1D + WacRuntime.Constants.arrayTypeSufix;
                    var type2D = new WacRuntime.TypeInformation(arrayTypeName2D, null, null, false, WacRuntime.TypeCategory.none, WacRuntime.TypeFlags.none);
                    type2D.arrayItemTypeInfo = type1D;
                    this.m_types[arrayTypeName2D] = type2D;
                }
            };
            return TypeRegistration;
        }());
        WacRuntime.TypeRegistration = TypeRegistration;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var Utility = (function () {
            function Utility() {
            }
            Utility.isNullOrUndefined = function (value) {
                if (value === null) {
                    return true;
                }
                if (typeof (value) === "undefined") {
                    return true;
                }
                return false;
            };
            Utility.isUndefined = function (value) {
                if (typeof (value) === "undefined") {
                    return true;
                }
                return false;
            };
            Utility.isNullOrEmptyString = function (value) {
                if (value === null) {
                    return true;
                }
                if (typeof (value) === "undefined") {
                    return true;
                }
                if (value.length == 0) {
                    return true;
                }
                return false;
            };
            Utility.trim = function (str) {
                return str.replace(new RegExp("^\\s+|\\s+$", "g"), "");
            };
            Utility.caseInsensitiveCompareString = function (str1, str2) {
                if (Utility.isNullOrUndefined(str1)) {
                    return Utility.isNullOrUndefined(str2);
                }
                else {
                    if (Utility.isNullOrUndefined(str2)) {
                        return false;
                    }
                    else {
                        return str1.toUpperCase() == str2.toUpperCase();
                    }
                }
            };
            Utility.createInvalidArgumentException = function (name) {
                return new WacRuntime.RichApiException(WacRuntime.ErrorCodes.invalidArgument, Utility.getLocalizedString(WacRuntime.ResourceStrings.invalidArgument, name));
            };
            Utility.createInvalidOperationException = function () {
                return new WacRuntime.RichApiException(WacRuntime.ErrorCodes.invalidOperation, Utility.getLocalizedString(WacRuntime.ResourceStrings.invalidOperation));
            };
            Utility.createInvalidRequestException = function () {
                return new WacRuntime.RichApiException(WacRuntime.ErrorCodes.invalidRequest, Utility.getLocalizedString(WacRuntime.ResourceStrings.invalidRequest));
            };
            Utility.createApiNotFoundException = function (apiName) {
                return new WacRuntime.RichApiException(WacRuntime.ErrorCodes.apiNotFound, Utility.getLocalizedString(WacRuntime.ResourceStrings.apiNotFound, apiName), Utility.httpStatusCode_BadRequest, apiName);
            };
            Utility.createRichApiException = function (code, message, httpStatusCode, location) {
                return new WacRuntime.RichApiException(code, message, httpStatusCode, location);
            };
            Utility.getLocalizedString = function (resourceId, arg) {
                var ret = resourceId;
                if (WacRuntime.settings.getLocalizedStringFunc) {
                    ret = WacRuntime.settings.getLocalizedStringFunc(resourceId);
                }
                if (!Utility.isNullOrEmptyString(arg)) {
                    ret = ret.replace("{0}", arg);
                }
                return ret;
            };
            Utility.createPromise = function (init) {
                return new OfficeExtension.Promise(init);
            };
            Utility.createPromiseFromResult = function (value) {
                return new OfficeExtension.Promise(function (resolve, reject) {
                    resolve(value);
                });
            };
            Utility.getAndValidateArgument = function (args, index, expectedType) {
                return Utility.validateArgument(args[index], expectedType);
            };
            Utility.validateArgument = function (value, expectedType) {
                var ret = value;
                if (Utility.isNullOrUndefined(value)) {
                    if (expectedType === Utility.s_expectedTypeInt) {
                        ret = 0;
                    }
                    else if (expectedType === Utility.s_expectedTypeNumber) {
                        ret = 0.0;
                    }
                    else if (expectedType === Utility.s_expectedTypeBoolean) {
                        ret = false;
                    }
                    else if (expectedType === Utility.s_expectedTypeDate) {
                        ret = new Date("1899-12-30T00:00:00.000Z");
                    }
                    else {
                        ret = null;
                    }
                }
                else if (expectedType !== Utility.s_expectedTypeAny) {
                    if (typeof (expectedType) === Utility.s_scriptTypeFunction) {
                        if (!(value instanceof expectedType)) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType === Utility.s_expectedTypeInt || expectedType === Utility.s_expectedTypeIntNullable) {
                        if (!Utility.isInt(ret)) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType === Utility.s_expectedTypeBoolean || expectedType === Utility.s_expectedTypeBooleanNullable) {
                        if (typeof (ret) !== Utility.s_scriptTypeBoolean) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType === Utility.s_expectedTypeNumber || expectedType === Utility.s_expectedTypeNumberNullable) {
                        if (typeof (ret) !== Utility.s_scriptTypeNumber) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType === Utility.s_expectedTypeDate || expectedType === Utility.s_expectedTypeDateNullable) {
                        if (!(ret instanceof Date)) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType === Utility.s_expectedTypeString) {
                        if (typeof (ret) !== Utility.s_scriptTypeString) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType.indexOf(Utility.s_expectedTypeArrayPrefix) === 0) {
                        if (!Array.isArray(ret)) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                    else if (expectedType.indexOf(".") > 0) {
                        var funcType = Utility.getTypeFromTypeName(expectedType);
                        if (!(ret instanceof funcType)) {
                            throw Utility.createInvalidArgumentException("value");
                        }
                    }
                }
                return ret;
            };
            Utility.getTypeFromTypeName = function (typeName) {
                var parts = typeName.split(".");
                if (parts.length == 0) {
                    throw Utility.createInvalidOperationException();
                }
                var ret = window;
                for (var i = 0; i < parts.length; i++) {
                    if (ret) {
                        ret = ret[parts[i]];
                    }
                    else {
                        throw Utility.createInvalidArgumentException("typeName");
                    }
                }
                if (ret && typeof (ret) === Utility.s_scriptTypeFunction) {
                    return ret;
                }
                else {
                    throw Utility.createInvalidArgumentException("typeName");
                }
            };
            Utility.isInt = function (n) {
                return Number(n) === n && n % 1 === 0;
            };
            Utility.httpStatusCode_BadRequest = 400;
            Utility.s_expectedTypeInt = "int";
            Utility.s_expectedTypeNumber = "number";
            Utility.s_expectedTypeBoolean = "boolean";
            Utility.s_expectedTypeString = "string";
            Utility.s_expectedTypeDate = "date";
            Utility.s_expectedTypeAny = "any";
            Utility.s_expectedTypeArrayPrefix = "Array<";
            Utility.s_expectedTypeNullableSuffix = "?";
            Utility.s_expectedTypeIntNullable = "int?";
            Utility.s_expectedTypeBooleanNullable = "boolean?";
            Utility.s_expectedTypeNumberNullable = "number?";
            Utility.s_expectedTypeDateNullable = "date?";
            Utility.s_scriptTypeNumber = "number";
            Utility.s_scriptTypeBoolean = "boolean";
            Utility.s_scriptTypeString = "string";
            Utility.s_scriptTypeFunction = "function";
            return Utility;
        }());
        WacRuntime.Utility = Utility;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var WacRuntime;
    (function (WacRuntime) {
        var UtilityInternal = (function () {
            function UtilityInternal() {
            }
            UtilityInternal.isUpper = function (ch) {
                return ch == ch.toUpperCase();
            };
            UtilityInternal.getApiName = function (parentTypeName, name) {
                var normalizedName = name;
                if (normalizedName == ".indexer") {
                    normalizedName = "GetItem";
                }
                normalizedName = UtilityInternal.toCamelLowerCase(normalizedName);
                var index = parentTypeName.lastIndexOf('.');
                if (index > 0) {
                    return parentTypeName.substr(index + 1) + "." + normalizedName;
                }
                return parentTypeName + "." + normalizedName;
            };
            UtilityInternal.toCamelLowerCase = function (name) {
                var index = 0;
                while (index < name.length && UtilityInternal.isUpper(name.charAt(index))) {
                    index++;
                }
                if (index < name.length) {
                    var lower = name.substr(0, index);
                    lower = lower.toLowerCase();
                    return lower + name.substr(index);
                }
                else {
                    return name.toLowerCase();
                }
            };
            UtilityInternal.getShortTypeName = function (name) {
                var index = name.lastIndexOf(".");
                if (index > 0) {
                    return name.substr(index + 1);
                }
                return name;
            };
            UtilityInternal.createObject = function (requestContext, typeInfo) {
                UtilityInternal.checkCreateObjectPermission(requestContext, typeInfo);
                var obj = requestContext.host.createInstance(typeInfo.name);
                return obj;
            };
            UtilityInternal.constructLogMessage = function (requestContext, methodName, richEx) {
                var log = { AppId: requestContext.host.appId(), ExceptionCode: richEx.code, ExceptionMessage: richEx.message };
                log[methodName] = richEx.location;
                return JSON.stringify(log);
            };
            UtilityInternal.invokePropertyGet = function (requestContext, typeInfo, propInfo, obj) {
                var dispatchId = propInfo.dispatchId;
                try {
                    UtilityInternal.logPropertyGetInvokeUsage(requestContext, propInfo);
                    UtilityInternal.checkPropertyGetPermission(requestContext, typeInfo, propInfo);
                    return obj.invokePropertyGet(dispatchId);
                }
                catch (ex) {
                    var richEx = UtilityInternal.convertToRichApiException(ex);
                    richEx.location = propInfo.apiName;
                    var log = UtilityInternal.constructLogMessage(requestContext, "PropertyGetError", richEx);
                    WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194841);
                    throw richEx;
                }
            };
            UtilityInternal.invokePropertyGetAsync = function (requestContext, typeInfo, propInfo, obj) {
                var dispatchId = propInfo.dispatchId;
                return WacRuntime.Utility.createPromiseFromResult(null)
                    .then(function () {
                    UtilityInternal.logPropertyGetInvokeUsage(requestContext, propInfo);
                    UtilityInternal.checkPropertyGetPermission(requestContext, typeInfo, propInfo);
                    return obj.invokePropertyGetAsync(dispatchId);
                })["catch"](function (err) {
                    var richEx = UtilityInternal.convertToRichApiException(err);
                    richEx.location = propInfo.apiName;
                    var log = UtilityInternal.constructLogMessage(requestContext, "PropertyGetAsyncError", richEx);
                    WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194842);
                    throw richEx;
                });
            };
            UtilityInternal.logPropertyGetInvokeUsage = function (requestContext, propInfo) {
                if (!WacRuntime.Utility.isNullOrEmptyString(propInfo.apiName)) {
                    var apiNames = propInfo.apiName.split(".");
                    if (apiNames.length > 1 && apiNames[1].charCodeAt(0) === UtilityInternal.s_underscoreCharCode) {
                        return;
                    }
                }
                var log = JSON.stringify({ AppId: requestContext.host.appId(), UsageDataType: 1, MethodName: propInfo.apiName });
                WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194843);
            };
            UtilityInternal.getTypeNameWithoutArraySuffix = function (typeName) {
                var index = typeName.indexOf('[');
                if (index > 0) {
                    return typeName.substr(0, index);
                }
                return typeName;
            };
            UtilityInternal.checkCreateObjectPermission = function (requestContext, typeInfo) {
                if (typeInfo.typeCategory === WacRuntime.TypeCategory.classObject) {
                    UtilityInternal.checkRestrictedResourceTypeFlags(requestContext, typeInfo.typeFlags, typeInfo.name);
                    UtilityInternal.checkMakerSafeTypeFlags(requestContext, typeInfo.typeFlags, typeInfo.name);
                }
            };
            UtilityInternal.checkPropertyGetPermission = function (requestContext, typeInfo, propInfo) {
                if (typeInfo.typeCategory === WacRuntime.TypeCategory.classObject &&
                    propInfo.propertyTypeCategory === WacRuntime.TypeCategory.classObject) {
                    UtilityInternal.checkRestrictedResourceApiFlags(requestContext, propInfo.apiFlags, propInfo.apiName);
                    UtilityInternal.checkMakerSafeApiFlags(requestContext, propInfo.apiFlags, propInfo.name, propInfo.apiName);
                }
            };
            UtilityInternal.checkPropertyWritePermission = function (requestContext, typeInfo, propInfo) {
                if (typeInfo.typeCategory === WacRuntime.TypeCategory.classObject) {
                    if ((requestContext.request.requestFlags & WacRuntime.RichApiRequestFlags.WriteOperation) === 0) {
                        throw UtilityInternal.createAccessDeniedException(propInfo.apiName);
                    }
                    UtilityInternal.checkRestrictedResourceApiFlags(requestContext, propInfo.apiFlags, propInfo.apiName);
                    UtilityInternal.checkMakerSafeApiFlags(requestContext, propInfo.apiFlags, propInfo.name, propInfo.apiName);
                }
            };
            UtilityInternal.checkMethodPermission = function (requestContext, typeInfo, methodInfo) {
                if (typeInfo.typeCategory === WacRuntime.TypeCategory.classObject) {
                    if (methodInfo.methodOperationType !== WacRuntime.OperationType.read &&
                        (requestContext.request.requestFlags & WacRuntime.RichApiRequestFlags.WriteOperation) === 0) {
                        throw UtilityInternal.createAccessDeniedException(methodInfo.apiName);
                    }
                    UtilityInternal.checkRestrictedResourceApiFlags(requestContext, methodInfo.apiFlags, methodInfo.apiName);
                    UtilityInternal.checkMakerSafeApiFlags(requestContext, methodInfo.apiFlags, methodInfo.name, methodInfo.apiName);
                }
            };
            UtilityInternal.checkMakerSafeTypeFlags = function (requestContext, typeFlags, apiName) {
                if ((requestContext.request.requestFlags & WacRuntime.RichApiRequestFlags.OnlyAllowMakerSafeApi) !== 0 &&
                    (typeFlags & WacRuntime.TypeFlags.makerSafe) === 0) {
                    throw UtilityInternal.createAccessDeniedException(apiName);
                }
            };
            UtilityInternal.isSpecialApiNotRequirePermissionCheck = function (name) {
                return (name === WacRuntime.Constants.getReferenceCount ||
                    name === WacRuntime.Constants.removeReference ||
                    name === WacRuntime.Constants.removeAllReferences ||
                    name === WacRuntime.Constants.keepReference ||
                    name === WacRuntime.Constants.onAccess);
            };
            UtilityInternal.checkMakerSafeApiFlags = function (requestContext, apiFlags, name, apiName) {
                if ((requestContext.request.requestFlags & WacRuntime.RichApiRequestFlags.OnlyAllowMakerSafeApi) !== 0 &&
                    (apiFlags & WacRuntime.ApiFlags.makerSafe) === 0) {
                    if (!UtilityInternal.isSpecialApiNotRequirePermissionCheck(name)) {
                        throw UtilityInternal.createAccessDeniedException(apiName);
                    }
                }
            };
            UtilityInternal.checkRestrictedResourceTypeFlags = function (requestContext, typeFlags, apiName) {
                if ((requestContext.request.requestFlags & WacRuntime.RichApiRequestFlags.RestrictedResourceAccess) === 0 &&
                    (typeFlags & WacRuntime.TypeFlags.restrictedResource) !== 0) {
                    throw UtilityInternal.createAccessDeniedException(apiName);
                }
            };
            UtilityInternal.checkRestrictedResourceApiFlags = function (requestContext, apiFlags, apiName) {
                if ((requestContext.request.requestFlags & WacRuntime.RichApiRequestFlags.RestrictedResourceAccess) === 0 &&
                    (apiFlags & WacRuntime.ApiFlags.restrictedResource) !== 0) {
                    throw UtilityInternal.createAccessDeniedException(apiName);
                }
            };
            UtilityInternal.invokePropertySet = function (requestContext, typeInfo, propInfo, obj, propValue, shouldCheckPerm) {
                var dispatchId = propInfo.dispatchId;
                try {
                    if (shouldCheckPerm) {
                        UtilityInternal.checkPropertyWritePermission(requestContext, typeInfo, propInfo);
                    }
                    UtilityInternal.logPropertySetInvokeUsage(requestContext, propInfo);
                    UtilityInternal.validateNotNullIfNecessary(propInfo.apiFlags, propValue);
                    obj.invokePropertySet(dispatchId, [propValue]);
                }
                catch (ex) {
                    var richEx = UtilityInternal.convertToRichApiException(ex);
                    richEx.location = propInfo.apiName;
                    var log = UtilityInternal.constructLogMessage(requestContext, "PropertySetError", richEx);
                    WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194844);
                    throw richEx;
                }
            };
            UtilityInternal.invokePropertySetAsync = function (requestContext, typeInfo, propInfo, obj, propValue) {
                var dispatchId = propInfo.dispatchId;
                return WacRuntime.Utility.createPromiseFromResult(null)
                    .then(function () {
                    UtilityInternal.logPropertySetInvokeUsage(requestContext, propInfo);
                    UtilityInternal.checkPropertyWritePermission(requestContext, typeInfo, propInfo);
                    UtilityInternal.validateNotNullIfNecessary(propInfo.apiFlags, propValue);
                    return obj.invokePropertySetAsync(dispatchId, [propValue]);
                })["catch"](function (err) {
                    var richEx = UtilityInternal.convertToRichApiException(err);
                    richEx.location = propInfo.apiName;
                    var log = UtilityInternal.constructLogMessage(requestContext, "PropertySetAsyncError", richEx);
                    WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194845);
                    throw richEx;
                });
            };
            UtilityInternal.logPropertySetInvokeUsage = function (requestContext, propInfo) {
                var log = JSON.stringify({ AppId: requestContext.host.appId(), UsageDataType: 2, MethodName: propInfo.apiName });
                WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194846);
            };
            UtilityInternal.validateNotNullIfNecessary = function (apiFlags, value) {
                if ((apiFlags & WacRuntime.ApiFlags.notNull) !== 0) {
                    if (WacRuntime.Utility.isNullOrUndefined(value)) {
                        throw WacRuntime.Utility.createInvalidArgumentException("value");
                    }
                }
            };
            UtilityInternal.validateMethodParameterNotNullIfNecessary = function (methodInfo, args) {
                var parameters = methodInfo.parameters;
                for (var i = 0; i < parameters.length; i++) {
                    var apiFlags = parameters[i].apiFlags;
                    var value = args[i];
                    UtilityInternal.validateNotNullIfNecessary(apiFlags, value);
                }
            };
            UtilityInternal.invokeMethod = function (requestContext, typeInfo, methodInfo, obj, args) {
                var dispatchId = methodInfo.dispatchId;
                try {
                    UtilityInternal.logMethodInvokeUsage(requestContext, methodInfo);
                    UtilityInternal.checkMethodPermission(requestContext, typeInfo, methodInfo);
                    UtilityInternal.validateMethodParameterNotNullIfNecessary(methodInfo, args);
                    return obj.invokeMethod(dispatchId, args);
                }
                catch (ex) {
                    var richEx = UtilityInternal.convertToRichApiException(ex);
                    richEx.location = methodInfo.apiName;
                    var log = UtilityInternal.constructLogMessage(requestContext, "MethodCallError", richEx);
                    WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194847);
                    throw richEx;
                }
            };
            UtilityInternal.invokeMethodAsync = function (requestContext, typeInfo, methodInfo, obj, args) {
                var dispatchId = methodInfo.dispatchId;
                return WacRuntime.Utility.createPromiseFromResult(null)
                    .then(function () {
                    UtilityInternal.logMethodInvokeUsage(requestContext, methodInfo);
                    UtilityInternal.checkMethodPermission(requestContext, typeInfo, methodInfo);
                    UtilityInternal.validateMethodParameterNotNullIfNecessary(methodInfo, args);
                    return obj.invokeMethodAsync(dispatchId, args);
                })["catch"](function (err) {
                    var richEx = UtilityInternal.convertToRichApiException(err);
                    richEx.location = methodInfo.apiName;
                    var log = UtilityInternal.constructLogMessage(requestContext, "MethodCallAsyncError", richEx);
                    WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194848);
                    throw richEx;
                });
            };
            UtilityInternal.logMethodInvokeUsage = function (requestContext, methodInfo) {
                if (!WacRuntime.Utility.isNullOrEmptyString(methodInfo.apiName)) {
                    var apiNames = methodInfo.apiName.split(".");
                    if (apiNames.length > 1 && apiNames[1].charCodeAt(0) === UtilityInternal.s_underscoreCharCode) {
                        return;
                    }
                }
                var log = JSON.stringify({ AppId: requestContext.host.appId(), UsageDataType: 3, MethodName: methodInfo.apiName });
                WacRuntime.Logger.SendULSTraceTag(log, requestContext.host.hostName(), 50, 0x02194849);
            };
            UtilityInternal.invokeGetAsyncEnumerator = function (requestContext, typeInfo, obj, skip, top) {
                return obj.getAsyncEnumerator(skip, top);
            };
            UtilityInternal.writeValue = function (writer, requestContext, typeInfo, value) {
                if (WacRuntime.Utility.isNullOrUndefined(value)) {
                    writer.writeValueNull();
                    return;
                }
                if (typeInfo) {
                    value = UtilityInternal.convertEnumValueToStringIfApplicable(typeInfo, value);
                }
                if (Array.isArray(value)) {
                    writer.startArrayScope();
                    var items = value;
                    for (var i = 0; i < items.length; i++) {
                        UtilityInternal.writeValue(writer, requestContext, null, items[i]);
                    }
                    writer.endScope();
                    return;
                }
                if (typeof (value) == "object" &&
                    typeof (value.getTypeName) == "function") {
                    var typeName = value.getTypeName();
                    var complexType = requestContext.typeReg.getType(typeName);
                    if (complexType.typeCategory != WacRuntime.TypeCategory.valueObject) {
                        throw WacRuntime.Utility.createInvalidOperationException();
                    }
                    UtilityInternal.writeComplexTypeValue(writer, requestContext, value, complexType);
                    return;
                }
                writer.writeValue(value);
            };
            UtilityInternal.writeComplexTypeValue = function (writer, requestContext, value, complexType) {
                writer.startObjectScope();
                writer.writeName("@odata.type");
                writer.writeValue(complexType.name);
                var fShouldSkipUndefindProperties = ((complexType.typeFlags & WacRuntime.TypeFlags.shouldSkipUndefinedProperties) == WacRuntime.TypeFlags.shouldSkipUndefinedProperties);
                for (var name in complexType.properties) {
                    var propInfo = complexType.properties[name];
                    var propTypeInfo = requestContext.typeReg.tryGetType(propInfo.propertyTypeName);
                    var propValue = UtilityInternal.invokePropertyGet(requestContext, complexType, propInfo, value);
                    if (propValue === undefined && fShouldSkipUndefindProperties) {
                        continue;
                    }
                    writer.writeName(propInfo.camelLowerCaseName);
                    UtilityInternal.writeValue(writer, requestContext, propTypeInfo, propValue);
                }
                writer.endScope();
            };
            UtilityInternal.convertEnumValueToStringIfApplicable = function (typeInfo, value) {
                if (typeInfo.isEnum && typeof (value) == "number") {
                    return typeInfo.getEnumFieldName(value);
                }
                if (Array.isArray(value)) {
                    var arrayItemType = typeInfo.arrayItemTypeInfo;
                    if (arrayItemType) {
                        var arr = value;
                        for (var i = 0; i < arr.length; i++) {
                            arr[i] = UtilityInternal.convertEnumValueToStringIfApplicable(arrayItemType, arr[i]);
                        }
                    }
                }
                return value;
            };
            UtilityInternal.convertToRichApiException = function (err) {
                var ret;
                if (err instanceof WacRuntime.RichApiException) {
                    ret = err;
                }
                else {
                    var msg;
                    if (err.message) {
                        msg = err.message;
                    }
                    else {
                        msg = err.toString();
                    }
                    ret = new WacRuntime.RichApiException(WacRuntime.ErrorCodes.generalException, msg);
                }
                return ret;
            };
            UtilityInternal.createAccessDeniedException = function (apiName) {
                var str = WacRuntime.Utility.getLocalizedString(WacRuntime.ResourceStrings.accessDenied);
                return WacRuntime.Utility.createRichApiException(WacRuntime.ErrorCodes.accessDenied, str, 403, apiName);
            };
            UtilityInternal.s_underscoreCharCode = "_".charCodeAt(0);
            return UtilityInternal;
        }());
        WacRuntime.UtilityInternal = UtilityInternal;
    })(WacRuntime = OfficeExtension.WacRuntime || (OfficeExtension.WacRuntime = {}));
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    ;
})(OfficeExtension || (OfficeExtension = {}));
var OfficeExtension;
(function (OfficeExtension) {
    var _Internal;
    (function (_Internal) {
        _Internal.OfficeRequire = function () {
            return null;
        }();
    })(_Internal = OfficeExtension._Internal || (OfficeExtension._Internal = {}));
    (function (_Internal) {
        var PromiseImpl;
        (function (PromiseImpl) {
            function Init() {
                return (function () {
                    "use strict";
                    function lib$es6$promise$utils$$objectOrFunction(x) {
                        return typeof x === 'function' || (typeof x === 'object' && x !== null);
                    }
                    function lib$es6$promise$utils$$isFunction(x) {
                        return typeof x === 'function';
                    }
                    function lib$es6$promise$utils$$isMaybeThenable(x) {
                        return typeof x === 'object' && x !== null;
                    }
                    var lib$es6$promise$utils$$_isArray;
                    if (!Array.isArray) {
                        lib$es6$promise$utils$$_isArray = function (x) {
                            return Object.prototype.toString.call(x) === '[object Array]';
                        };
                    }
                    else {
                        lib$es6$promise$utils$$_isArray = Array.isArray;
                    }
                    var lib$es6$promise$utils$$isArray = lib$es6$promise$utils$$_isArray;
                    var lib$es6$promise$asap$$len = 0;
                    var lib$es6$promise$asap$$toString = {}.toString;
                    var lib$es6$promise$asap$$vertxNext;
                    var lib$es6$promise$asap$$customSchedulerFn;
                    var lib$es6$promise$asap$$asap = function asap(callback, arg) {
                        lib$es6$promise$asap$$queue[lib$es6$promise$asap$$len] = callback;
                        lib$es6$promise$asap$$queue[lib$es6$promise$asap$$len + 1] = arg;
                        lib$es6$promise$asap$$len += 2;
                        if (lib$es6$promise$asap$$len === 2) {
                            if (lib$es6$promise$asap$$customSchedulerFn) {
                                lib$es6$promise$asap$$customSchedulerFn(lib$es6$promise$asap$$flush);
                            }
                            else {
                                lib$es6$promise$asap$$scheduleFlush();
                            }
                        }
                    };
                    function lib$es6$promise$asap$$setScheduler(scheduleFn) {
                        lib$es6$promise$asap$$customSchedulerFn = scheduleFn;
                    }
                    function lib$es6$promise$asap$$setAsap(asapFn) {
                        lib$es6$promise$asap$$asap = asapFn;
                    }
                    var lib$es6$promise$asap$$browserWindow = (typeof window !== 'undefined') ? window : undefined;
                    var lib$es6$promise$asap$$browserGlobal = lib$es6$promise$asap$$browserWindow || {};
                    var lib$es6$promise$asap$$BrowserMutationObserver = lib$es6$promise$asap$$browserGlobal.MutationObserver || lib$es6$promise$asap$$browserGlobal.WebKitMutationObserver;
                    var lib$es6$promise$asap$$isNode = typeof process !== 'undefined' && {}.toString.call(process) === '[object process]';
                    var lib$es6$promise$asap$$isWorker = typeof Uint8ClampedArray !== 'undefined' &&
                        typeof importScripts !== 'undefined' &&
                        typeof MessageChannel !== 'undefined';
                    function lib$es6$promise$asap$$useNextTick() {
                        var nextTick = process.nextTick;
                        var version = process.versions.node.match(/^(?:(\d+)\.)?(?:(\d+)\.)?(\*|\d+)$/);
                        if (Array.isArray(version) && version[1] === '0' && version[2] === '10') {
                            nextTick = window.setImmediate;
                        }
                        return function () {
                            nextTick(lib$es6$promise$asap$$flush);
                        };
                    }
                    function lib$es6$promise$asap$$useVertxTimer() {
                        return function () {
                            lib$es6$promise$asap$$vertxNext(lib$es6$promise$asap$$flush);
                        };
                    }
                    function lib$es6$promise$asap$$useMutationObserver() {
                        var iterations = 0;
                        var observer = new lib$es6$promise$asap$$BrowserMutationObserver(lib$es6$promise$asap$$flush);
                        var node = document.createTextNode('');
                        observer.observe(node, { characterData: true });
                        return function () {
                            node.data = (iterations = ++iterations % 2);
                        };
                    }
                    function lib$es6$promise$asap$$useMessageChannel() {
                        var channel = new MessageChannel();
                        channel.port1.onmessage = lib$es6$promise$asap$$flush;
                        return function () {
                            channel.port2.postMessage(0);
                        };
                    }
                    function lib$es6$promise$asap$$useSetTimeout() {
                        return function () {
                            setTimeout(lib$es6$promise$asap$$flush, 1);
                        };
                    }
                    var lib$es6$promise$asap$$queue = new Array(1000);
                    function lib$es6$promise$asap$$flush() {
                        for (var i = 0; i < lib$es6$promise$asap$$len; i += 2) {
                            var callback = lib$es6$promise$asap$$queue[i];
                            var arg = lib$es6$promise$asap$$queue[i + 1];
                            callback(arg);
                            lib$es6$promise$asap$$queue[i] = undefined;
                            lib$es6$promise$asap$$queue[i + 1] = undefined;
                        }
                        lib$es6$promise$asap$$len = 0;
                    }
                    var lib$es6$promise$asap$$scheduleFlush;
                    if (lib$es6$promise$asap$$isNode) {
                        lib$es6$promise$asap$$scheduleFlush = lib$es6$promise$asap$$useNextTick();
                    }
                    else if (lib$es6$promise$asap$$isWorker) {
                        lib$es6$promise$asap$$scheduleFlush = lib$es6$promise$asap$$useMessageChannel();
                    }
                    else {
                        lib$es6$promise$asap$$scheduleFlush = lib$es6$promise$asap$$useSetTimeout();
                    }
                    function lib$es6$promise$$internal$$noop() { }
                    var lib$es6$promise$$internal$$PENDING = void 0;
                    var lib$es6$promise$$internal$$FULFILLED = 1;
                    var lib$es6$promise$$internal$$REJECTED = 2;
                    var lib$es6$promise$$internal$$GET_THEN_ERROR = new lib$es6$promise$$internal$$ErrorObject();
                    function lib$es6$promise$$internal$$selfFullfillment() {
                        return new TypeError("You cannot resolve a promise with itself");
                    }
                    function lib$es6$promise$$internal$$cannotReturnOwn() {
                        return new TypeError('A promises callback cannot return that same promise.');
                    }
                    function lib$es6$promise$$internal$$getThen(promise) {
                        try {
                            return promise.then;
                        }
                        catch (error) {
                            lib$es6$promise$$internal$$GET_THEN_ERROR.error = error;
                            return lib$es6$promise$$internal$$GET_THEN_ERROR;
                        }
                    }
                    function lib$es6$promise$$internal$$tryThen(then, value, fulfillmentHandler, rejectionHandler) {
                        try {
                            then.call(value, fulfillmentHandler, rejectionHandler);
                        }
                        catch (e) {
                            return e;
                        }
                    }
                    function lib$es6$promise$$internal$$handleForeignThenable(promise, thenable, then) {
                        lib$es6$promise$asap$$asap(function (promise) {
                            var sealed = false;
                            var error = lib$es6$promise$$internal$$tryThen(then, thenable, function (value) {
                                if (sealed) {
                                    return;
                                }
                                sealed = true;
                                if (thenable !== value) {
                                    lib$es6$promise$$internal$$resolve(promise, value);
                                }
                                else {
                                    lib$es6$promise$$internal$$fulfill(promise, value);
                                }
                            }, function (reason) {
                                if (sealed) {
                                    return;
                                }
                                sealed = true;
                                lib$es6$promise$$internal$$reject(promise, reason);
                            }, 'Settle: ' + (promise._label || ' unknown promise'));
                            if (!sealed && error) {
                                sealed = true;
                                lib$es6$promise$$internal$$reject(promise, error);
                            }
                        }, promise);
                    }
                    function lib$es6$promise$$internal$$handleOwnThenable(promise, thenable) {
                        if (thenable._state === lib$es6$promise$$internal$$FULFILLED) {
                            lib$es6$promise$$internal$$fulfill(promise, thenable._result);
                        }
                        else if (thenable._state === lib$es6$promise$$internal$$REJECTED) {
                            lib$es6$promise$$internal$$reject(promise, thenable._result);
                        }
                        else {
                            lib$es6$promise$$internal$$subscribe(thenable, undefined, function (value) {
                                lib$es6$promise$$internal$$resolve(promise, value);
                            }, function (reason) {
                                lib$es6$promise$$internal$$reject(promise, reason);
                            });
                        }
                    }
                    function lib$es6$promise$$internal$$handleMaybeThenable(promise, maybeThenable) {
                        if (maybeThenable.constructor === promise.constructor) {
                            lib$es6$promise$$internal$$handleOwnThenable(promise, maybeThenable);
                        }
                        else {
                            var then = lib$es6$promise$$internal$$getThen(maybeThenable);
                            if (then === lib$es6$promise$$internal$$GET_THEN_ERROR) {
                                lib$es6$promise$$internal$$reject(promise, lib$es6$promise$$internal$$GET_THEN_ERROR.error);
                            }
                            else if (then === undefined) {
                                lib$es6$promise$$internal$$fulfill(promise, maybeThenable);
                            }
                            else if (lib$es6$promise$utils$$isFunction(then)) {
                                lib$es6$promise$$internal$$handleForeignThenable(promise, maybeThenable, then);
                            }
                            else {
                                lib$es6$promise$$internal$$fulfill(promise, maybeThenable);
                            }
                        }
                    }
                    function lib$es6$promise$$internal$$resolve(promise, value) {
                        if (promise === value) {
                            lib$es6$promise$$internal$$reject(promise, lib$es6$promise$$internal$$selfFullfillment());
                        }
                        else if (lib$es6$promise$utils$$objectOrFunction(value)) {
                            lib$es6$promise$$internal$$handleMaybeThenable(promise, value);
                        }
                        else {
                            lib$es6$promise$$internal$$fulfill(promise, value);
                        }
                    }
                    function lib$es6$promise$$internal$$publishRejection(promise) {
                        if (promise._onerror) {
                            promise._onerror(promise._result);
                        }
                        lib$es6$promise$$internal$$publish(promise);
                    }
                    function lib$es6$promise$$internal$$fulfill(promise, value) {
                        if (promise._state !== lib$es6$promise$$internal$$PENDING) {
                            return;
                        }
                        promise._result = value;
                        promise._state = lib$es6$promise$$internal$$FULFILLED;
                        if (promise._subscribers.length !== 0) {
                            lib$es6$promise$asap$$asap(lib$es6$promise$$internal$$publish, promise);
                        }
                    }
                    function lib$es6$promise$$internal$$reject(promise, reason) {
                        if (promise._state !== lib$es6$promise$$internal$$PENDING) {
                            return;
                        }
                        promise._state = lib$es6$promise$$internal$$REJECTED;
                        promise._result = reason;
                        lib$es6$promise$asap$$asap(lib$es6$promise$$internal$$publishRejection, promise);
                    }
                    function lib$es6$promise$$internal$$subscribe(parent, child, onFulfillment, onRejection) {
                        var subscribers = parent._subscribers;
                        var length = subscribers.length;
                        parent._onerror = null;
                        subscribers[length] = child;
                        subscribers[length + lib$es6$promise$$internal$$FULFILLED] = onFulfillment;
                        subscribers[length + lib$es6$promise$$internal$$REJECTED] = onRejection;
                        if (length === 0 && parent._state) {
                            lib$es6$promise$asap$$asap(lib$es6$promise$$internal$$publish, parent);
                        }
                    }
                    function lib$es6$promise$$internal$$publish(promise) {
                        var subscribers = promise._subscribers;
                        var settled = promise._state;
                        if (subscribers.length === 0) {
                            return;
                        }
                        var child, callback, detail = promise._result;
                        for (var i = 0; i < subscribers.length; i += 3) {
                            child = subscribers[i];
                            callback = subscribers[i + settled];
                            if (child) {
                                lib$es6$promise$$internal$$invokeCallback(settled, child, callback, detail);
                            }
                            else {
                                callback(detail);
                            }
                        }
                        promise._subscribers.length = 0;
                    }
                    function lib$es6$promise$$internal$$ErrorObject() {
                        this.error = null;
                    }
                    var lib$es6$promise$$internal$$TRY_CATCH_ERROR = new lib$es6$promise$$internal$$ErrorObject();
                    function lib$es6$promise$$internal$$tryCatch(callback, detail) {
                        try {
                            return callback(detail);
                        }
                        catch (e) {
                            lib$es6$promise$$internal$$TRY_CATCH_ERROR.error = e;
                            return lib$es6$promise$$internal$$TRY_CATCH_ERROR;
                        }
                    }
                    function lib$es6$promise$$internal$$invokeCallback(settled, promise, callback, detail) {
                        var hasCallback = lib$es6$promise$utils$$isFunction(callback), value, error, succeeded, failed;
                        if (hasCallback) {
                            value = lib$es6$promise$$internal$$tryCatch(callback, detail);
                            if (value === lib$es6$promise$$internal$$TRY_CATCH_ERROR) {
                                failed = true;
                                error = value.error;
                                value = null;
                            }
                            else {
                                succeeded = true;
                            }
                            if (promise === value) {
                                lib$es6$promise$$internal$$reject(promise, lib$es6$promise$$internal$$cannotReturnOwn());
                                return;
                            }
                        }
                        else {
                            value = detail;
                            succeeded = true;
                        }
                        if (promise._state !== lib$es6$promise$$internal$$PENDING) {
                        }
                        else if (hasCallback && succeeded) {
                            lib$es6$promise$$internal$$resolve(promise, value);
                        }
                        else if (failed) {
                            lib$es6$promise$$internal$$reject(promise, error);
                        }
                        else if (settled === lib$es6$promise$$internal$$FULFILLED) {
                            lib$es6$promise$$internal$$fulfill(promise, value);
                        }
                        else if (settled === lib$es6$promise$$internal$$REJECTED) {
                            lib$es6$promise$$internal$$reject(promise, value);
                        }
                    }
                    function lib$es6$promise$$internal$$initializePromise(promise, resolver) {
                        try {
                            resolver(function resolvePromise(value) {
                                lib$es6$promise$$internal$$resolve(promise, value);
                            }, function rejectPromise(reason) {
                                lib$es6$promise$$internal$$reject(promise, reason);
                            });
                        }
                        catch (e) {
                            lib$es6$promise$$internal$$reject(promise, e);
                        }
                    }
                    function lib$es6$promise$enumerator$$Enumerator(Constructor, input) {
                        var enumerator = this;
                        enumerator._instanceConstructor = Constructor;
                        enumerator.promise = new Constructor(lib$es6$promise$$internal$$noop);
                        if (enumerator._validateInput(input)) {
                            enumerator._input = input;
                            enumerator.length = input.length;
                            enumerator._remaining = input.length;
                            enumerator._init();
                            if (enumerator.length === 0) {
                                lib$es6$promise$$internal$$fulfill(enumerator.promise, enumerator._result);
                            }
                            else {
                                enumerator.length = enumerator.length || 0;
                                enumerator._enumerate();
                                if (enumerator._remaining === 0) {
                                    lib$es6$promise$$internal$$fulfill(enumerator.promise, enumerator._result);
                                }
                            }
                        }
                        else {
                            lib$es6$promise$$internal$$reject(enumerator.promise, enumerator._validationError());
                        }
                    }
                    lib$es6$promise$enumerator$$Enumerator.prototype._validateInput = function (input) {
                        return lib$es6$promise$utils$$isArray(input);
                    };
                    lib$es6$promise$enumerator$$Enumerator.prototype._validationError = function () {
                        return new Error('Array Methods must be provided an Array');
                    };
                    lib$es6$promise$enumerator$$Enumerator.prototype._init = function () {
                        this._result = new Array(this.length);
                    };
                    var lib$es6$promise$enumerator$$default = lib$es6$promise$enumerator$$Enumerator;
                    lib$es6$promise$enumerator$$Enumerator.prototype._enumerate = function () {
                        var enumerator = this;
                        var length = enumerator.length;
                        var promise = enumerator.promise;
                        var input = enumerator._input;
                        for (var i = 0; promise._state === lib$es6$promise$$internal$$PENDING && i < length; i++) {
                            enumerator._eachEntry(input[i], i);
                        }
                    };
                    lib$es6$promise$enumerator$$Enumerator.prototype._eachEntry = function (entry, i) {
                        var enumerator = this;
                        var c = enumerator._instanceConstructor;
                        if (lib$es6$promise$utils$$isMaybeThenable(entry)) {
                            if (entry.constructor === c && entry._state !== lib$es6$promise$$internal$$PENDING) {
                                entry._onerror = null;
                                enumerator._settledAt(entry._state, i, entry._result);
                            }
                            else {
                                enumerator._willSettleAt(c.resolve(entry), i);
                            }
                        }
                        else {
                            enumerator._remaining--;
                            enumerator._result[i] = entry;
                        }
                    };
                    lib$es6$promise$enumerator$$Enumerator.prototype._settledAt = function (state, i, value) {
                        var enumerator = this;
                        var promise = enumerator.promise;
                        if (promise._state === lib$es6$promise$$internal$$PENDING) {
                            enumerator._remaining--;
                            if (state === lib$es6$promise$$internal$$REJECTED) {
                                lib$es6$promise$$internal$$reject(promise, value);
                            }
                            else {
                                enumerator._result[i] = value;
                            }
                        }
                        if (enumerator._remaining === 0) {
                            lib$es6$promise$$internal$$fulfill(promise, enumerator._result);
                        }
                    };
                    lib$es6$promise$enumerator$$Enumerator.prototype._willSettleAt = function (promise, i) {
                        var enumerator = this;
                        lib$es6$promise$$internal$$subscribe(promise, undefined, function (value) {
                            enumerator._settledAt(lib$es6$promise$$internal$$FULFILLED, i, value);
                        }, function (reason) {
                            enumerator._settledAt(lib$es6$promise$$internal$$REJECTED, i, reason);
                        });
                    };
                    function lib$es6$promise$promise$all$$all(entries) {
                        return new lib$es6$promise$enumerator$$default(this, entries).promise;
                    }
                    var lib$es6$promise$promise$all$$default = lib$es6$promise$promise$all$$all;
                    function lib$es6$promise$promise$race$$race(entries) {
                        var Constructor = this;
                        var promise = new Constructor(lib$es6$promise$$internal$$noop);
                        if (!lib$es6$promise$utils$$isArray(entries)) {
                            lib$es6$promise$$internal$$reject(promise, new TypeError('You must pass an array to race.'));
                            return promise;
                        }
                        var length = entries.length;
                        function onFulfillment(value) {
                            lib$es6$promise$$internal$$resolve(promise, value);
                        }
                        function onRejection(reason) {
                            lib$es6$promise$$internal$$reject(promise, reason);
                        }
                        for (var i = 0; promise._state === lib$es6$promise$$internal$$PENDING && i < length; i++) {
                            lib$es6$promise$$internal$$subscribe(Constructor.resolve(entries[i]), undefined, onFulfillment, onRejection);
                        }
                        return promise;
                    }
                    var lib$es6$promise$promise$race$$default = lib$es6$promise$promise$race$$race;
                    function lib$es6$promise$promise$resolve$$resolve(object) {
                        var Constructor = this;
                        if (object && typeof object === 'object' && object.constructor === Constructor) {
                            return object;
                        }
                        var promise = new Constructor(lib$es6$promise$$internal$$noop);
                        lib$es6$promise$$internal$$resolve(promise, object);
                        return promise;
                    }
                    var lib$es6$promise$promise$resolve$$default = lib$es6$promise$promise$resolve$$resolve;
                    function lib$es6$promise$promise$reject$$reject(reason) {
                        var Constructor = this;
                        var promise = new Constructor(lib$es6$promise$$internal$$noop);
                        lib$es6$promise$$internal$$reject(promise, reason);
                        return promise;
                    }
                    var lib$es6$promise$promise$reject$$default = lib$es6$promise$promise$reject$$reject;
                    var lib$es6$promise$promise$$counter = 0;
                    function lib$es6$promise$promise$$needsResolver() {
                        throw new TypeError('You must pass a resolver function as the first argument to the promise constructor');
                    }
                    function lib$es6$promise$promise$$needsNew() {
                        throw new TypeError("Failed to construct 'Promise': Please use the 'new' operator, this object constructor cannot be called as a function.");
                    }
                    var lib$es6$promise$promise$$default = lib$es6$promise$promise$$Promise;
                    function lib$es6$promise$promise$$Promise(resolver) {
                        this._id = lib$es6$promise$promise$$counter++;
                        this._state = undefined;
                        this._result = undefined;
                        this._subscribers = [];
                        if (lib$es6$promise$$internal$$noop !== resolver) {
                            if (!lib$es6$promise$utils$$isFunction(resolver)) {
                                lib$es6$promise$promise$$needsResolver();
                            }
                            if (!(this instanceof lib$es6$promise$promise$$Promise)) {
                                lib$es6$promise$promise$$needsNew();
                            }
                            lib$es6$promise$$internal$$initializePromise(this, resolver);
                        }
                    }
                    lib$es6$promise$promise$$Promise.all = lib$es6$promise$promise$all$$default;
                    lib$es6$promise$promise$$Promise.race = lib$es6$promise$promise$race$$default;
                    lib$es6$promise$promise$$Promise.resolve = lib$es6$promise$promise$resolve$$default;
                    lib$es6$promise$promise$$Promise.reject = lib$es6$promise$promise$reject$$default;
                    lib$es6$promise$promise$$Promise._setScheduler = lib$es6$promise$asap$$setScheduler;
                    lib$es6$promise$promise$$Promise._setAsap = lib$es6$promise$asap$$setAsap;
                    lib$es6$promise$promise$$Promise._asap = lib$es6$promise$asap$$asap;
                    lib$es6$promise$promise$$Promise.prototype = {
                        constructor: lib$es6$promise$promise$$Promise,
                        then: function (onFulfillment, onRejection) {
                            var parent = this;
                            var state = parent._state;
                            if (state === lib$es6$promise$$internal$$FULFILLED && !onFulfillment || state === lib$es6$promise$$internal$$REJECTED && !onRejection) {
                                return this;
                            }
                            var child = new this.constructor(lib$es6$promise$$internal$$noop);
                            var result = parent._result;
                            if (state) {
                                var callback = arguments[state - 1];
                                lib$es6$promise$asap$$asap(function () {
                                    lib$es6$promise$$internal$$invokeCallback(state, child, callback, result);
                                });
                            }
                            else {
                                lib$es6$promise$$internal$$subscribe(parent, child, onFulfillment, onRejection);
                            }
                            return child;
                        },
                        'catch': function (onRejection) {
                            return this.then(null, onRejection);
                        }
                    };
                    return lib$es6$promise$promise$$default;
                }).call(this);
            }
            PromiseImpl.Init = Init;
        })(PromiseImpl = _Internal.PromiseImpl || (_Internal.PromiseImpl = {}));
    })(_Internal = OfficeExtension._Internal || (OfficeExtension._Internal = {}));
    (function (_Internal) {
        function isEdgeLessThan14() {
            var userAgent = window.navigator.userAgent;
            var versionIdx = userAgent.indexOf("Edge/");
            if (versionIdx >= 0) {
                userAgent = userAgent.substring(versionIdx + 5, userAgent.length);
                if (userAgent < "14.14393")
                    return true;
                else
                    return false;
            }
            return false;
        }
        function determinePromise() {
            if (typeof (window) === "undefined" && typeof (Promise) === "function") {
                return Promise;
            }
            if (typeof (window) !== "undefined" && window.Promise) {
                if (isEdgeLessThan14()) {
                    return _Internal.PromiseImpl.Init();
                }
                else {
                    return window.Promise;
                }
            }
            else {
                return _Internal.PromiseImpl.Init();
            }
        }
        _Internal.OfficePromise = determinePromise();
    })(_Internal = OfficeExtension._Internal || (OfficeExtension._Internal = {}));
    var OfficePromise = _Internal.OfficePromise;
    OfficeExtension.Promise = OfficePromise;
})(OfficeExtension || (OfficeExtension = {}));
