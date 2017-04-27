#ifndef HEADER_AVOPENHOMEORGSENDER2
#define HEADER_AVOPENHOMEORGSENDER2

#include <OpenHome/Types.h>
#include <OpenHome/Buffer.h>
#include <OpenHome/Exception.h>
#include <OpenHome/Functor.h>
#include <OpenHome/Net/Core/FunctorAsync.h>
#include <OpenHome/Net/Core/CpProxy.h>

namespace OpenHome {
namespace Net {

class CpDevice;
class Action;
class PropertyBinary;
class PropertyBool;
class PropertyInt;
class PropertyString;
class PropertyUint;
class CpProxy;
class ICpProxyAvOpenhomeOrgSender2 : public ICpProxy
{
public:
    virtual ~ICpProxyAvOpenhomeOrgSender2() {}
    virtual void SyncPresentationUrl(Brh& aValue) = 0;
    virtual void BeginPresentationUrl(FunctorAsync& aFunctor) = 0;
    virtual void EndPresentationUrl(IAsync& aAsync, Brh& aValue) = 0;
    virtual void SyncMetadata(Brh& aValue) = 0;
    virtual void BeginMetadata(FunctorAsync& aFunctor) = 0;
    virtual void EndMetadata(IAsync& aAsync, Brh& aValue) = 0;
    virtual void SyncAudio(TBool& aValue) = 0;
    virtual void BeginAudio(FunctorAsync& aFunctor) = 0;
    virtual void EndAudio(IAsync& aAsync, TBool& aValue) = 0;
    virtual void SyncStatus(Brh& aValue) = 0;
    virtual void BeginStatus(FunctorAsync& aFunctor) = 0;
    virtual void EndStatus(IAsync& aAsync, Brh& aValue) = 0;
    virtual void SyncStatus2(Brh& aValue) = 0;
    virtual void BeginStatus2(FunctorAsync& aFunctor) = 0;
    virtual void EndStatus2(IAsync& aAsync, Brh& aValue) = 0;
    virtual void SyncEnabled(TBool& aValue) = 0;
    virtual void BeginEnabled(FunctorAsync& aFunctor) = 0;
    virtual void EndEnabled(IAsync& aAsync, TBool& aValue) = 0;
    virtual void SyncAttributes(Brh& aValue) = 0;
    virtual void BeginAttributes(FunctorAsync& aFunctor) = 0;
    virtual void EndAttributes(IAsync& aAsync, Brh& aValue) = 0;
    virtual void SetPropertyPresentationUrlChanged(Functor& aPresentationUrlChanged) = 0;
    virtual void PropertyPresentationUrl(Brhz& aPresentationUrl) const = 0;
    virtual void SetPropertyMetadataChanged(Functor& aMetadataChanged) = 0;
    virtual void PropertyMetadata(Brhz& aMetadata) const = 0;
    virtual void SetPropertyAudioChanged(Functor& aAudioChanged) = 0;
    virtual void PropertyAudio(TBool& aAudio) const = 0;
    virtual void SetPropertyStatusChanged(Functor& aStatusChanged) = 0;
    virtual void PropertyStatus(Brhz& aStatus) const = 0;
    virtual void SetPropertyStatus2Changed(Functor& aStatus2Changed) = 0;
    virtual void PropertyStatus2(Brhz& aStatus2) const = 0;
    virtual void SetPropertyEnabledChanged(Functor& aEnabledChanged) = 0;
    virtual void PropertyEnabled(TBool& aEnabled) const = 0;
    virtual void SetPropertyAttributesChanged(Functor& aAttributesChanged) = 0;
    virtual void PropertyAttributes(Brhz& aAttributes) const = 0;
};

/**
 * Proxy for av.openhome.org:Sender:2
 * @ingroup Proxies
 */
class CpProxyAvOpenhomeOrgSender2 : public ICpProxyAvOpenhomeOrgSender2
{
public:
    /**
     * Constructor.
     *
     * Use iCpProxy::[Un]Subscribe() to enable/disable querying of state variable
     * and reporting of their changes.
     *
     * @param[in]  aDevice   The device to use
     */
    CpProxyAvOpenhomeOrgSender2(CpDevice& aDevice);
    /**
     * Destructor.
     * If any asynchronous method is in progress, this will block until they complete.
     * [Note that any methods still in progress are likely to complete with an error.]
     * Clients who have called Subscribe() do not need to call Unsubscribe() before
     * calling delete.  An unsubscribe will be triggered automatically when required.
     */
    ~CpProxyAvOpenhomeOrgSender2();

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncPresentationUrl(Brh& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndPresentationUrl().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginPresentationUrl(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndPresentationUrl(IAsync& aAsync, Brh& aValue);

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncMetadata(Brh& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndMetadata().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginMetadata(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndMetadata(IAsync& aAsync, Brh& aValue);

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncAudio(TBool& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndAudio().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginAudio(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndAudio(IAsync& aAsync, TBool& aValue);

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncStatus(Brh& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndStatus().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginStatus(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndStatus(IAsync& aAsync, Brh& aValue);

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncStatus2(Brh& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndStatus2().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginStatus2(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndStatus2(IAsync& aAsync, Brh& aValue);

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncEnabled(TBool& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndEnabled().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginEnabled(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndEnabled(IAsync& aAsync, TBool& aValue);

    /**
     * Invoke the action synchronously.  Blocks until the action has been processed
     * on the device and sets any output arguments.
     *
     * @param[out] aValue
     */
    void SyncAttributes(Brh& aValue);
    /**
     * Invoke the action asynchronously.
     * Returns immediately and will run the client-specified callback when the action
     * later completes.  Any output arguments can then be retrieved by calling
     * EndAttributes().
     *
     * @param[in] aFunctor   Callback to run when the action completes.
     *                       This is guaranteed to be run but may indicate an error
     */
    void BeginAttributes(FunctorAsync& aFunctor);
    /**
     * Retrieve the output arguments from an asynchronously invoked action.
     * This may only be called from the callback set in the above Begin function.
     *
     * @param[in]  aAsync  Argument passed to the callback set in the above Begin function
     * @param[out] aValue
     */
    void EndAttributes(IAsync& aAsync, Brh& aValue);

    /**
     * Set a callback to be run when the PresentationUrl state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyPresentationUrlChanged(Functor& aFunctor);
    /**
     * Set a callback to be run when the Metadata state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyMetadataChanged(Functor& aFunctor);
    /**
     * Set a callback to be run when the Audio state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyAudioChanged(Functor& aFunctor);
    /**
     * Set a callback to be run when the Status state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyStatusChanged(Functor& aFunctor);
    /**
     * Set a callback to be run when the Status2 state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyStatus2Changed(Functor& aFunctor);
    /**
     * Set a callback to be run when the Enabled state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyEnabledChanged(Functor& aFunctor);
    /**
     * Set a callback to be run when the Attributes state variable changes.
     *
     * Callbacks may be run in different threads but callbacks for a
     * CpProxyAvOpenhomeOrgSender2 instance will not overlap.
     *
     * @param[in]  aFunctor  The callback to run when the state variable changes
     */
    void SetPropertyAttributesChanged(Functor& aFunctor);

    /**
     * Query the value of the PresentationUrl property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aPresentationUrl
     */
    void PropertyPresentationUrl(Brhz& aPresentationUrl) const;
    /**
     * Query the value of the Metadata property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aMetadata
     */
    void PropertyMetadata(Brhz& aMetadata) const;
    /**
     * Query the value of the Audio property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aAudio
     */
    void PropertyAudio(TBool& aAudio) const;
    /**
     * Query the value of the Status property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aStatus
     */
    void PropertyStatus(Brhz& aStatus) const;
    /**
     * Query the value of the Status2 property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aStatus2
     */
    void PropertyStatus2(Brhz& aStatus2) const;
    /**
     * Query the value of the Enabled property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aEnabled
     */
    void PropertyEnabled(TBool& aEnabled) const;
    /**
     * Query the value of the Attributes property.
     *
     * This function is threadsafe and can only be called if Subscribe() has been
     * called and a first eventing callback received more recently than any call
     * to Unsubscribe().
     *
     * @param[out] aAttributes
     */
    void PropertyAttributes(Brhz& aAttributes) const;
    /**
    * This function exposes the Subscribe() function of the iCpProxy member variable
    */
    void Subscribe();
    /**
    * This function exposes the Unsubscribe() function of the iCpProxy member variable
    */
    void Unsubscribe();
    /**
    * This function exposes the SetPropertyChanged() function of the iCpProxy member variable
    */
    void SetPropertyChanged(Functor& aFunctor);
    /**
    * This function exposes the SetPropertyInitialEvent() function of the iCpProxy member variable
    */
    void SetPropertyInitialEvent(Functor& aFunctor);
    /**
    * This function exposes the AddProperty() function of the iCpProxy member variable
    */
    void AddProperty(Property* aProperty);
    /**
    * This function exposes DestroyService() function of the iCpProxy member variable
    */
    void DestroyService();
    /**
    * This function exposes the REportEvent() function of the iCpProxy member variable
    */
    void ReportEvent(Functor aFunctor);
    /**
    * This function exposes the Version() function of the iCpProxy member variable
    */
    TUint Version() const;
private:
    CpProxy iCpProxy;
    void PresentationUrlPropertyChanged();
    void MetadataPropertyChanged();
    void AudioPropertyChanged();
    void StatusPropertyChanged();
    void Status2PropertyChanged();
    void EnabledPropertyChanged();
    void AttributesPropertyChanged();
private:
    Action* iActionPresentationUrl;
    Action* iActionMetadata;
    Action* iActionAudio;
    Action* iActionStatus;
    Action* iActionStatus2;
    Action* iActionEnabled;
    Action* iActionAttributes;
    PropertyString* iPresentationUrl;
    PropertyString* iMetadata;
    PropertyBool* iAudio;
    PropertyString* iStatus;
    PropertyString* iStatus2;
    PropertyBool* iEnabled;
    PropertyString* iAttributes;
    Functor iPresentationUrlChanged;
    Functor iMetadataChanged;
    Functor iAudioChanged;
    Functor iStatusChanged;
    Functor iStatus2Changed;
    Functor iEnabledChanged;
    Functor iAttributesChanged;
};

} // namespace Net
} // namespace OpenHome

#endif // HEADER_AVOPENHOMEORGSENDER2

