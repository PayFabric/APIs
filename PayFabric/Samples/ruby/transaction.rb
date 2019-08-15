require "rest_client"
require "json"

module PayFabric
  #
  # `Transaction` module provide methods fro work with Transaction API
  # see [API](https://github.com/PayFabric/APIs/tree/master/PayFabric)
  # Module contatin two submodues
  # `Sandbox` - for communicate with `sandbox` api
  # `Live` - for production usage
  module Transaction
    # private
    module Share #:nodoc:
      extend self 
      def create(url, device_id, password, options) #:nodoc:
        response = RestClient.post(url, 
          options.to_json, 
          PayFabric::headers(device_id, password, url.include?("sandbox"))
        )
        JSON.parse(response.body)
      end

      def update(url, device_id, password, options) #:nodoc:
        response = RestClient.post(url, 
          options.to_json, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def process(url, device_id, password) #:nodoc:
        response = RestClient.get(url, 
         PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def process_object(url, device_id, password, options) #:nodoc:
        response = RestClient.post(url, 
          options.to_json, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def retrieve(url, device_id, password) #:nodoc:
        response = RestClient.get(url, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def capture(url, device_id, password) #:nodoc:
        response = RestClient.get(url, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end
      
      def cancel(url, device_id, password) #:nodoc:
        response = RestClient.get(url, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end
    end

    module Sandbox
      extend self 
      # ## Create a new Transaction
      # To create and save a new payment transaction on PayFabric without submitting to pament gateway.
      # [More Info](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#create-a-transaction)
      # 
      # +options+ - trasaction hash [see](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction)
      # @return Hash 
      #
      #  Example: 
      #    
      #    options = {
      #      "Customer" => "AARONFIT0001",
      #      "Currency" => "USD",
      #      "Amount"   => "4.88",
      #      "Type"     => "Sale",
      #      "SetupId"  => "Paypal"
      #    }
      #    hash = PayFabric::Transaction::Sandbox::create(device_id, password, options)
      #    hash # => {"Key" => "140527000010"}
      # 
      def create(device_id, password, options)
        url = "https://sandbox.payfabric.com/payment/api/transaction/create"
        Share::create(url, device_id, password, options)
      end

      #  ## Update a Transaction
      #  [Info](https://github.com/PayFabric/APIs/wiki#update-a-transaction)
      #  Update an existing transaction before it's processed. Once a transaction is processed, only the "UserDefined" fields can be updated.
      #  +options+ - trasaction hash [see](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction)
      #  @return Hash 
      #
      #  Example:
      #
      #    transaction_key = "some transaction key"
      #
      #    options = {
      #      "Key"  => transaction_key,
      #      "Card" => {
      #      "ID"    => "cb111170-d7ba-4bf8-aae4-3477e12853b0"
      #       }
      #    }
      #    
      #    hash = PayFabric::Transaction::Sandbox::update(device_id, password, options)
      #    hash # => {"Result" => "true"}
      # 
      def update(device_id, password, options)
        url = "https://sandbox.payfabric.com/payment/api/transaction/update"
        Share::create(url, device_id, password, options)
      end

      #  ## Process a Transaction by Transaction Key
      #  [Info](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#process-a-transaction)
      #  You must make sure the transaction key you are going to process is previously created and saved on PayFabric, as well as all required fields have been set already.
      #  
      #  +trx_key+ - transaction key
      #
      #  Example:
      #
      #    trx_key = "you transaction key" 
      #    hash = PayFabric::Transaction::Sandbox::process(device_id, password, trx_key)  
      #    hash # => {
      #       "AVSAddressResponse" => "Y",
      #       "AVSZipResponse" => "Y",
      #        "AuthCode" => "010010",
      #        "CVV2Response" => "Y",
      #        "IAVSAddressResponse" => "Y",
      #        "Message" => "APPROVED",
      #        "OriginationID" => "987220999",
      #        "RespTrxTag" => "",
      #        "ResultCode" => "0",
      #        "Status" => "Approved",
      #        "TrxDate" => "",
      #        "TrxKey" => "140500229001"
      #      }  
      #
      # @return [Transaction Response](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction-response)
      #  
      def process(device_id, password, trx_key)
        url = "https://sandbox.payfabric.com/payment/api/transaction/process/#{trx_key}"
        Share::process(url, device_id, password)
      end

      #  ## Process a Transaction by Transaction Object
      #  [Info](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#create-and-process-a-transaction)
      #  Besides processing a payment transaction by several steps, PayFabric also offers an API call that can submit and process transaction within one internet round trip, as below.
      # 
      #  +options+ - [Transaction Object](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction)
      #
      #  Example:
      #    options = {
      #      "Customer" => "AARONFIT0001",
      #      "Currency" => "USD",
      #         "Card" => {
      #           "ID" => "cb111170-d7ba-4bf8-aae4-3477e12853b0"
      #         }
      #       }  
      #    hash = PayFabric::Transaction::Sandbox::process_object(device_id, password, options)
      #    hash # => {
      #         "AVSAddressResponse" => "Y",
      #         "AVSZipResponse" => "Y",
      #         "AuthCode" => "010010",
      #         "CVV2Response" => "Y",
      #         "IAVSAddressResponse" => "Y",
      #         "Message" => "APPROVED",
      #         "OriginationID" => "987220999",
      #         "RespTrxTag" => "",
      #         "ResultCode" => "0",
      #         "Status" => "Approved",
      #         "TrxDate" => "",
      #         "TrxKey" => "140500229001"
      #       }
      #   
      #  @return [Transaction Response Object](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction-response)
      #
      #  
      def process_object(device_id, password, options)
        url = "https://sandbox.payfabric.com/payment/api/transaction/process"
        Share::process_object(url, device_id, password, options)
      end

      #  ## Retrieve a Transaction
      #  [Info](https://github.com/PayFabric/APIs/wiki#retrieve-a-transaction)
      #  
      #  +trx_key+ - transaction key
      #  
      #  Example:
      #    trx_key = "transaction key"
      #    hash = PayFabric::Transaction::Sandbox::retrieve(device_id, password, trx_key)
      #    hash # => 
      #      {
      #       "Customer" => "AARONFIT0001",
      #       "Currency" => "USD",
      #       "Card" => {
      #         "ID" => "cb111170-d7ba-4bf8-aae4-3477e12853b0"
      #       }
      #     }
      #     
      #  @return [Transaction](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction)  
      #
      def retrieve(device_id, password, trx_key)
        url = "https://sandbox.payfabric.com/payment/api/transaction/#{trx_key}"
        Share::retrieve(url, device_id, password)   
      end

      #  ## Capture a Pre-Authorized Transaction
      #  [Info](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#referenced-transactions-void-capture-ship-or-credit)
      #  
      #  +trx_key+ - transaction key
      #  
      #  Example 
      #    trx_key = "transaction key"
      #    hash = PayFabric::Transaction::Sandbox::capture(device_id, password, trx_key)
      #    hash # => {
      #         "AVSAddressResponse" => "Y",
      #         "AVSZipResponse" => "Y",
      #         "AuthCode" => "010010",
      #         "CVV2Response" => "Y",
      #         "IAVSAddressResponse" => "Y",
      #         "Message" => "APPROVED",
      #         "OriginationID" => "987220999",
      #         "RespTrxTag" => "",
      #         "ResultCode" => "0",
      #         "Status" => "Approved",
      #         "TrxDate" => "",
      #         "TrxKey" => "140500229001"
      #       }
      # 
      #  @return [Transaction Response](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction-response)
      # 
      def capture(device_id, password, trx_key)
        url = "https://sandbox.payfabric.com/payment/api/reference/#{trx_key}?trxtype=Ship"
        Share::capture(url, device_id, password)
      end

      #  ## Cancel a Transaction
      #  [Info](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#referenced-transactions-void-capture-ship-or-credit)
      #  
      #  +trx_key+ - transaction key
      #  
      #  Example
      #    trx_key = "transaction key"
      #    hash = PayFabric::Transaction::Sandbox::cancel(device_id, password, trx_key)
      #    hash # => 
      #       {
      #           "AVSAddressResponse" => "Y",
      #           "AVSZipResponse" => "Y",
      #           "AuthCode" => "010010",
      #           "CVV2Response" => "Y",
      #           "IAVSAddressResponse" => "Y",
      #           "Message" => "APPROVED",
      #           "OriginationID" => "987220999",
      #           "RespTrxTag" => "",
      #           "ResultCode" => "0",
      #           "Status" => "Approved",
      #           "TrxDate" => "",
      #           "TrxKey" => "140500229001"
      #         }
      #  
      #  @return [Transaction Response](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction-response)   
      #
      def cancel(device_id, password, trx_key)
        url = "https://sandbox.payfabric.com/payment/api/reference/#{trx_key}?trxtype=Void"
        Share::cancel(url, device_id, password)
      end

      #  ## Refund a Customer
      #  [Info](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#referenced-transactions-void-capture-ship-or-credit)
      #  
      #  +options+ - Hash object  
      #
      #  Example 
      #    options = {
      #       "Customer" => "ARRONFIT0003",
      #       "Amount" => "10.05",
      #       "Currency" => "USD",
      #       "Type" => "Credit",
      #       "SetupId" => "PayPal",
      #       "Card" => {
      #         "ID" => "cb111170-d7ba-4bf8-aae4-3477e12853b0"
      #     }
      #     }
      #
      #    hash = PayFabric::Transaction::Sandbox::refund(device_id, password, options)
      #    hash # => 
      #         {
      #           "AVSAddressResponse" => nil,
      #           "AVSZipResponse" => nil,
      #           "AuthCode" => nil,
      #           "CVV2Response" => nil,
      #           "IAVSAddressResponse" => nil,
      #           "Message" => "Approved",
      #           "OriginationID" => "A70E6C184BA5",
      #           "RespTrxTag" => nil,
      #           "ResultCode" => "0",
      #           "Status" => "Approved",
      #           "TrxDate" => "5\/31\/2014 3:17:27 PM",
      #           "TrxKey" => "140531067716"
      #         }
      #     
      def refund(device_id, password, options) 
        url = "https://sandbox.payfabric.com/payment/api/transaction/process"
        Share::process_object(url, device_id, password, options)
      end
    end

    module Live
      extend self 
      # see Sandbox::create
      def create(device_id, password, options)
        url = "https://www.payfabric.com/payment/api/transaction/create"
        Share::create(url, device_id, password, options)
      end
      # see Sandbox::update
      def update(device_id, password, options)
        url = "https://www.payfabric.com/payment/api/transaction/update"
        Share::create(url, device_id, password, options)
      end
      # see Sandbox::process
      def process(device_id, password, trx_key)
        url = "https://www.payfabric.com/payment/api/transaction/process/#{trx_key}"
        Share::process(url, device_id, password)
      end
      # see Sandbox::process_object
      def process_object(device_id, password, options)
        url = "https://www.payfabric.com/payment/api/transaction/process"
        Share::process_object(url, device_id, password, options)
      end
      # see Sandbox::retrieve
      def retrieve(device_id, password, trx_key)
        url = "https://www.payfabric.com/payment/api/transaction/#{trx_key}"
        Share::retrieve(url, device_id, password)   
      end
      # see Sandbox::capture
      def capture(device_id, password, trx_key)
        url = "https://www.payfabric.com/payment/api/reference/#{trx_key}?trxtype=Ship"
        Share::capture(url, device_id, password)
      end
      # see Sandbox::cancel
      def cancel(device_id, password, trx_key)
        url = "https://www.payfabric.com/payment/api/reference/#{trx_key}?trxtype=Void"
        Share::cancel(url, device_id, password)
      end
      # see Sandbox::refund
      def refund(device_id, password, options) 
        url = "https://www.payfabric.com/payment/api/transaction/process"
        Share::process_object(url, device_id, password, options)
      end
    end
  end

end

