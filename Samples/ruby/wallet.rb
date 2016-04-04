require "rest_client"
require "json"

module PayFabric
  # 
  #  Module for work with Wallet 
  #  Contain two submodules
  #  `Sandbox` for work with sandbox api
  #  `Live` for work with production api  
  module Wallet
    module Share #:nodoc:
      extend self
        
      def add(url, device_id, password, options) #:nodoc:
        response = RestClient.post(url, 
          options.to_json, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def update(url, device_id, password, options) #:nodoc:
        response = RestClient.post(url, 
          options.to_json, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def remove(url, device_id, password) #:nodoc:
        response = RestClient.get(url, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end

      def retrieve(url, device_id, password) #:nodoc:
        response = RestClient.get(url, 
          PayFabric::headers(device_id, password, url.include?("sandbox")))
        JSON.parse(response.body)
      end
    end

    module Sandbox
      extend self
      #  ## Add a Card Into Wallet
      #  [Info](https://github.com/PayFabric/APIs/wiki#add-a-card-into-wallet)
      #
      #  +options+ - [Card hash](https://github.com/PayFabric/APIs/wiki/API-Objects#card)
      #  
      #  Example 
      #    
      #    options = {
      #       "Tender"     => "CreditCard",
      #       "Customer"   => "ARRONFIT0001",
      #       "Account"    => "5555555555554444",
      #       "Cvc"        => "1453",
      #       "CardName"   => "MasterCard",
      #       "ExpDate"    => "0115",
      #       "CardHolder" => {
      #         "Name"     => "jason zhao"
      #       },
      #       "Billto" => {
      #         "Country" => "US",
      #         "State"   => "CA",
      #         "City"    => "ANAHEIM",
      #         "Line1"   => "2099 S State College Blvd",
      #         "Email"   => "support@payfabric.com"
      #       },
      #       "IsDefaultCard" => true,
      #       "UserDefined1"  => "Example",
      #       "UserDefined2"  => "Example"
      #     }
      #
      #     hash = PayFabric::Wallet::Sandbox::add(device_id, password, options)
      #     hash # => 
      #      {
      #        "Message" => "",
      #        "Result" => "1627aea5-8e0a-4371-9022-9b504344e724"  
      #      }
      #
      #  @return Hash
      # 
      def add(device_id, password, options)
        url = "https://sandbox.payfabric.com/rest/v1/api/wallet/create"
        Share::add(url, device_id, password, options)
      end

      #  ## Update an Existing Card
      #  [Info](https://github.com/PayFabric/APIs/wiki#update-an-existing-card)
      #  
      #  +options+ - [Card hash](https://github.com/PayFabric/APIs/wiki/API-Objects#card)
      #  
      #  Example
      #    
      #    options = {
      #         "ID"     => "123",
      #         "ExpDate"    => "0219",
      #         "Billto" => {
      #           "City"    => "ANAHEIM",
      #           "Line1"   => "Fullerton Blvd"
      #         },
      #         "UserDefined1"  => "Example",
      #         "UserDefined2"  => "Example"
      #       } 
      #
      #    hash = PayFabric::Wallet::Sandbox::update(device_id, password, options)
      #    hash # => {"Result" => "true" }
      # 
      # @return Hash
      #
      def update(device_id, password, options)
        url = "https://sandbox.payfabric.com/rest/v1/api/wallet/update"
        Share::update(url, device_id, password, options)
      end

      #  ## Remove a Card  
      #  [Info](https://github.com/PayFabric/APIs/wiki#remove-a-card)
      #  
      #  +id+ - Card ID 
      #  
      #  Example 
      #   
      #    id = "1111"
      #    hash = PayFabric::Wallet::Sandbox::remove(device_id, password, id)
      #    hash # => {"Result" => "true"}
      # 
      def remove(device_id, password, id)
        url = "https://sandbox.payfabric.com/rest/v1/api/wallet/delete/#{id}"
        Share::remove(url, device_id, password)
      end

      #  ## Retrieve Cards By Customer
      #  [Info](https://github.com/PayFabric/APIs/wiki#retrieve-cards-by-customer)
      #  
      #  +customer+ - customer name
      #  
      #  Example
      #    
      #    customer = "uniq name"
      #
      #    hash  = PayFabric::Wallet::Sandbox::retrieve(device_id, password, customer)
      #    hash # => [{"ID" => "123" }, { "ID" => "124" }]
      #
      #  @reutrn [Array of Cards](https://github.com/PayFabric/APIs/wiki/API-Objects#card)
      # 
      def retrieve(device_id, password, customer)
        url = "https://sandbox.payfabric.com/rest/v1/api/wallet/get/#{customer}"
        Share::retrieve(url, device_id, password)
      end
    end

    module Live
      extend self
      def add(device_id, password, options)
        url = "https://payfabric.com/rest/v1/api/wallet/create"
        Share::add(url, device_id, password, options)
      end

      def update(device_id, password, options)
        url = "https://payfabric.com/rest/v1/api/wallet/update"
        Share::update(url, device_id, password, options)
      end

      def remove(device_id, password, id)
        url = "https://payfabric.com/rest/v1/api/wallet/delete/#{id}"
        Share::remove(url, device_id, password)
      end

      def retrieve(device_id, password, customer)
        url = "https://payfabric.com/rest/v1/api/wallet/get/#{customer}"
        Share::retrieve(url, device_id, password)
      end
    end
  end
end
