using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenHome.Net.Core;
using OpenHome.Net.ControlPoint;

namespace OpenHome.Net.ControlPoint.Proxies
{
    public interface ICpProxyAvOpenhomeOrgSender2 : ICpProxy, IDisposable
    {
        void SyncPresentationUrl(out String aValue);
        void BeginPresentationUrl(CpProxy.CallbackAsyncComplete aCallback);
        void EndPresentationUrl(IntPtr aAsyncHandle, out String aValue);
        void SyncMetadata(out String aValue);
        void BeginMetadata(CpProxy.CallbackAsyncComplete aCallback);
        void EndMetadata(IntPtr aAsyncHandle, out String aValue);
        void SyncAudio(out bool aValue);
        void BeginAudio(CpProxy.CallbackAsyncComplete aCallback);
        void EndAudio(IntPtr aAsyncHandle, out bool aValue);
        void SyncStatus(out String aValue);
        void BeginStatus(CpProxy.CallbackAsyncComplete aCallback);
        void EndStatus(IntPtr aAsyncHandle, out String aValue);
        void SyncStatus2(out String aValue);
        void BeginStatus2(CpProxy.CallbackAsyncComplete aCallback);
        void EndStatus2(IntPtr aAsyncHandle, out String aValue);
        void SyncEnabled(out bool aValue);
        void BeginEnabled(CpProxy.CallbackAsyncComplete aCallback);
        void EndEnabled(IntPtr aAsyncHandle, out bool aValue);
        void SyncAttributes(out String aValue);
        void BeginAttributes(CpProxy.CallbackAsyncComplete aCallback);
        void EndAttributes(IntPtr aAsyncHandle, out String aValue);
        void SetPropertyPresentationUrlChanged(System.Action aPresentationUrlChanged);
        String PropertyPresentationUrl();
        void SetPropertyMetadataChanged(System.Action aMetadataChanged);
        String PropertyMetadata();
        void SetPropertyAudioChanged(System.Action aAudioChanged);
        bool PropertyAudio();
        void SetPropertyStatusChanged(System.Action aStatusChanged);
        String PropertyStatus();
        void SetPropertyStatus2Changed(System.Action aStatus2Changed);
        String PropertyStatus2();
        void SetPropertyEnabledChanged(System.Action aEnabledChanged);
        bool PropertyEnabled();
        void SetPropertyAttributesChanged(System.Action aAttributesChanged);
        String PropertyAttributes();
    }

    internal class SyncPresentationUrlAvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private String iValue;

        public SyncPresentationUrlAvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public String Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndPresentationUrl(aAsyncHandle, out iValue);
        }
    };

    internal class SyncMetadataAvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private String iValue;

        public SyncMetadataAvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public String Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndMetadata(aAsyncHandle, out iValue);
        }
    };

    internal class SyncAudioAvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private bool iValue;

        public SyncAudioAvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public bool Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndAudio(aAsyncHandle, out iValue);
        }
    };

    internal class SyncStatusAvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private String iValue;

        public SyncStatusAvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public String Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndStatus(aAsyncHandle, out iValue);
        }
    };

    internal class SyncStatus2AvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private String iValue;

        public SyncStatus2AvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public String Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndStatus2(aAsyncHandle, out iValue);
        }
    };

    internal class SyncEnabledAvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private bool iValue;

        public SyncEnabledAvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public bool Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndEnabled(aAsyncHandle, out iValue);
        }
    };

    internal class SyncAttributesAvOpenhomeOrgSender2 : SyncProxyAction
    {
        private CpProxyAvOpenhomeOrgSender2 iService;
        private String iValue;

        public SyncAttributesAvOpenhomeOrgSender2(CpProxyAvOpenhomeOrgSender2 aProxy)
        {
            iService = aProxy;
        }
        public String Value()
        {
            return iValue;
        }
        protected override void CompleteRequest(IntPtr aAsyncHandle)
        {
            iService.EndAttributes(aAsyncHandle, out iValue);
        }
    };

    /// <summary>
    /// Proxy for the av.openhome.org:Sender:2 UPnP service
    /// </summary>
    public class CpProxyAvOpenhomeOrgSender2 : CpProxy, IDisposable, ICpProxyAvOpenhomeOrgSender2
    {
        private OpenHome.Net.Core.Action iActionPresentationUrl;
        private OpenHome.Net.Core.Action iActionMetadata;
        private OpenHome.Net.Core.Action iActionAudio;
        private OpenHome.Net.Core.Action iActionStatus;
        private OpenHome.Net.Core.Action iActionStatus2;
        private OpenHome.Net.Core.Action iActionEnabled;
        private OpenHome.Net.Core.Action iActionAttributes;
        private PropertyString iPresentationUrl;
        private PropertyString iMetadata;
        private PropertyBool iAudio;
        private PropertyString iStatus;
        private PropertyString iStatus2;
        private PropertyBool iEnabled;
        private PropertyString iAttributes;
        private System.Action iPresentationUrlChanged;
        private System.Action iMetadataChanged;
        private System.Action iAudioChanged;
        private System.Action iStatusChanged;
        private System.Action iStatus2Changed;
        private System.Action iEnabledChanged;
        private System.Action iAttributesChanged;
        private Mutex iPropertyLock;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <remarks>Use CpProxy::[Un]Subscribe() to enable/disable querying of state variable and reporting of their changes.</remarks>
        /// <param name="aDevice">The device to use</param>
        public CpProxyAvOpenhomeOrgSender2(ICpDevice aDevice)
            : base("av-openhome-org", "Sender", 2, aDevice)
        {
            OpenHome.Net.Core.Parameter param;
            List<String> allowedValues = new List<String>();

            iActionPresentationUrl = new OpenHome.Net.Core.Action("PresentationUrl");
            param = new ParameterString("Value", allowedValues);
            iActionPresentationUrl.AddOutputParameter(param);

            iActionMetadata = new OpenHome.Net.Core.Action("Metadata");
            param = new ParameterString("Value", allowedValues);
            iActionMetadata.AddOutputParameter(param);

            iActionAudio = new OpenHome.Net.Core.Action("Audio");
            param = new ParameterBool("Value");
            iActionAudio.AddOutputParameter(param);

            iActionStatus = new OpenHome.Net.Core.Action("Status");
            allowedValues.Add("Enabled");
            allowedValues.Add("Disabled");
            allowedValues.Add("Blocked");
            param = new ParameterString("Value", allowedValues);
            iActionStatus.AddOutputParameter(param);
            allowedValues.Clear();

            iActionStatus2 = new OpenHome.Net.Core.Action("Status2");
            allowedValues.Add("Sending");
            allowedValues.Add("Ready");
            allowedValues.Add("Blocked");
            allowedValues.Add("Inactive");
            allowedValues.Add("Disabled");
            param = new ParameterString("Value", allowedValues);
            iActionStatus2.AddOutputParameter(param);
            allowedValues.Clear();

            iActionEnabled = new OpenHome.Net.Core.Action("Enabled");
            param = new ParameterBool("Value");
            iActionEnabled.AddOutputParameter(param);

            iActionAttributes = new OpenHome.Net.Core.Action("Attributes");
            param = new ParameterString("Value", allowedValues);
            iActionAttributes.AddOutputParameter(param);

            iPresentationUrl = new PropertyString("PresentationUrl", PresentationUrlPropertyChanged);
            AddProperty(iPresentationUrl);
            iMetadata = new PropertyString("Metadata", MetadataPropertyChanged);
            AddProperty(iMetadata);
            iAudio = new PropertyBool("Audio", AudioPropertyChanged);
            AddProperty(iAudio);
            iStatus = new PropertyString("Status", StatusPropertyChanged);
            AddProperty(iStatus);
            iStatus2 = new PropertyString("Status2", Status2PropertyChanged);
            AddProperty(iStatus2);
            iEnabled = new PropertyBool("Enabled", EnabledPropertyChanged);
            AddProperty(iEnabled);
            iAttributes = new PropertyString("Attributes", AttributesPropertyChanged);
            AddProperty(iAttributes);
            
            iPropertyLock = new Mutex();
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncPresentationUrl(out String aValue)
        {
            SyncPresentationUrlAvOpenhomeOrgSender2 sync = new SyncPresentationUrlAvOpenhomeOrgSender2(this);
            BeginPresentationUrl(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndPresentationUrl().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginPresentationUrl(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionPresentationUrl, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionPresentationUrl.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndPresentationUrl(IntPtr aAsyncHandle, out String aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncMetadata(out String aValue)
        {
            SyncMetadataAvOpenhomeOrgSender2 sync = new SyncMetadataAvOpenhomeOrgSender2(this);
            BeginMetadata(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndMetadata().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginMetadata(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionMetadata, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionMetadata.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndMetadata(IntPtr aAsyncHandle, out String aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncAudio(out bool aValue)
        {
            SyncAudioAvOpenhomeOrgSender2 sync = new SyncAudioAvOpenhomeOrgSender2(this);
            BeginAudio(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndAudio().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginAudio(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionAudio, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentBool((ParameterBool)iActionAudio.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndAudio(IntPtr aAsyncHandle, out bool aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputBool(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncStatus(out String aValue)
        {
            SyncStatusAvOpenhomeOrgSender2 sync = new SyncStatusAvOpenhomeOrgSender2(this);
            BeginStatus(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndStatus().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginStatus(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionStatus, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionStatus.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndStatus(IntPtr aAsyncHandle, out String aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncStatus2(out String aValue)
        {
            SyncStatus2AvOpenhomeOrgSender2 sync = new SyncStatus2AvOpenhomeOrgSender2(this);
            BeginStatus2(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndStatus2().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginStatus2(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionStatus2, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionStatus2.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndStatus2(IntPtr aAsyncHandle, out String aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncEnabled(out bool aValue)
        {
            SyncEnabledAvOpenhomeOrgSender2 sync = new SyncEnabledAvOpenhomeOrgSender2(this);
            BeginEnabled(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndEnabled().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginEnabled(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionEnabled, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentBool((ParameterBool)iActionEnabled.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndEnabled(IntPtr aAsyncHandle, out bool aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputBool(aAsyncHandle, index++);
        }

        /// <summary>
        /// Invoke the action synchronously
        /// </summary>
        /// <remarks>Blocks until the action has been processed
        /// on the device and sets any output arguments</remarks>
        /// <param name="aValue"></param>
        public void SyncAttributes(out String aValue)
        {
            SyncAttributesAvOpenhomeOrgSender2 sync = new SyncAttributesAvOpenhomeOrgSender2(this);
            BeginAttributes(sync.AsyncComplete());
            sync.Wait();
            sync.ReportError();
            aValue = sync.Value();
        }

        /// <summary>
        /// Invoke the action asynchronously
        /// </summary>
        /// <remarks>Returns immediately and will run the client-specified callback when the action
        /// later completes.  Any output arguments can then be retrieved by calling
        /// EndAttributes().</remarks>
        /// <param name="aCallback">Delegate to run when the action completes.
        /// This is guaranteed to be run but may indicate an error</param>
        public void BeginAttributes(CallbackAsyncComplete aCallback)
        {
            Invocation invocation = iService.Invocation(iActionAttributes, aCallback);
            int outIndex = 0;
            invocation.AddOutput(new ArgumentString((ParameterString)iActionAttributes.OutputParameter(outIndex++)));
            iService.InvokeAction(invocation);
        }

        /// <summary>
        /// Retrieve the output arguments from an asynchronously invoked action.
        /// </summary>
        /// <remarks>This may only be called from the callback set in the above Begin function.</remarks>
        /// <param name="aAsyncHandle">Argument passed to the delegate set in the above Begin function</param>
        /// <param name="aValue"></param>
        public void EndAttributes(IntPtr aAsyncHandle, out String aValue)
        {
            uint code;
            string desc;
            if (Invocation.Error(aAsyncHandle, out code, out desc))
            {
                throw new ProxyError(code, desc);
            }
            uint index = 0;
            aValue = Invocation.OutputString(aAsyncHandle, index++);
        }

        /// <summary>
        /// Set a delegate to be run when the PresentationUrl state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aPresentationUrlChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyPresentationUrlChanged(System.Action aPresentationUrlChanged)
        {
            lock (iPropertyLock)
            {
                iPresentationUrlChanged = aPresentationUrlChanged;
            }
        }

        private void PresentationUrlPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iPresentationUrlChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Metadata state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aMetadataChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyMetadataChanged(System.Action aMetadataChanged)
        {
            lock (iPropertyLock)
            {
                iMetadataChanged = aMetadataChanged;
            }
        }

        private void MetadataPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iMetadataChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Audio state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aAudioChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyAudioChanged(System.Action aAudioChanged)
        {
            lock (iPropertyLock)
            {
                iAudioChanged = aAudioChanged;
            }
        }

        private void AudioPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iAudioChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Status state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aStatusChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyStatusChanged(System.Action aStatusChanged)
        {
            lock (iPropertyLock)
            {
                iStatusChanged = aStatusChanged;
            }
        }

        private void StatusPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iStatusChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Status2 state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aStatus2Changed">The delegate to run when the state variable changes</param>
        public void SetPropertyStatus2Changed(System.Action aStatus2Changed)
        {
            lock (iPropertyLock)
            {
                iStatus2Changed = aStatus2Changed;
            }
        }

        private void Status2PropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iStatus2Changed);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Enabled state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aEnabledChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyEnabledChanged(System.Action aEnabledChanged)
        {
            lock (iPropertyLock)
            {
                iEnabledChanged = aEnabledChanged;
            }
        }

        private void EnabledPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iEnabledChanged);
            }
        }

        /// <summary>
        /// Set a delegate to be run when the Attributes state variable changes.
        /// </summary>
        /// <remarks>Callbacks may be run in different threads but callbacks for a
        /// CpProxyAvOpenhomeOrgSender2 instance will not overlap.</remarks>
        /// <param name="aAttributesChanged">The delegate to run when the state variable changes</param>
        public void SetPropertyAttributesChanged(System.Action aAttributesChanged)
        {
            lock (iPropertyLock)
            {
                iAttributesChanged = aAttributesChanged;
            }
        }

        private void AttributesPropertyChanged()
        {
            lock (iPropertyLock)
            {
                ReportEvent(iAttributesChanged);
            }
        }

        /// <summary>
        /// Query the value of the PresentationUrl property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the PresentationUrl property</returns>
        public String PropertyPresentationUrl()
        {
            PropertyReadLock();
            String val;
            try
            {
                val = iPresentationUrl.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Query the value of the Metadata property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Metadata property</returns>
        public String PropertyMetadata()
        {
            PropertyReadLock();
            String val;
            try
            {
                val = iMetadata.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Query the value of the Audio property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Audio property</returns>
        public bool PropertyAudio()
        {
            PropertyReadLock();
            bool val;
            try
            {
                val = iAudio.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Query the value of the Status property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Status property</returns>
        public String PropertyStatus()
        {
            PropertyReadLock();
            String val;
            try
            {
                val = iStatus.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Query the value of the Status2 property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Status2 property</returns>
        public String PropertyStatus2()
        {
            PropertyReadLock();
            String val;
            try
            {
                val = iStatus2.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Query the value of the Enabled property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Enabled property</returns>
        public bool PropertyEnabled()
        {
            PropertyReadLock();
            bool val;
            try
            {
                val = iEnabled.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Query the value of the Attributes property.
        /// </summary>
        /// <remarks>This function is threadsafe and can only be called if Subscribe() has been
        /// called and a first eventing callback received more recently than any call
        /// to Unsubscribe().</remarks>
        /// <returns>Value of the Attributes property</returns>
        public String PropertyAttributes()
        {
            PropertyReadLock();
            String val;
            try
            {
                val = iAttributes.Value();
            }
            finally
            {
                PropertyReadUnlock();
            }
            return val;
        }

        /// <summary>
        /// Must be called for each class instance.  Must be called before Core.Library.Close().
        /// </summary>
        public void Dispose()
        {
            lock (this)
            {
                if (iHandle == IntPtr.Zero)
                    return;
                DisposeProxy();
                iHandle = IntPtr.Zero;
            }
            iActionPresentationUrl.Dispose();
            iActionMetadata.Dispose();
            iActionAudio.Dispose();
            iActionStatus.Dispose();
            iActionStatus2.Dispose();
            iActionEnabled.Dispose();
            iActionAttributes.Dispose();
            iPresentationUrl.Dispose();
            iMetadata.Dispose();
            iAudio.Dispose();
            iStatus.Dispose();
            iStatus2.Dispose();
            iEnabled.Dispose();
            iAttributes.Dispose();
        }
    }
}

