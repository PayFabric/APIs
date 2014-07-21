require "rest_client"
require "json"

module PayFabric
  # 
  #  module provides methods for work with 
  #  `Sandbox` submodule provides methods for work with sandbox api
  #  `Live` submodule provides methods for work with production api
  module ShippingAdress
    module Share #:nodoc:
      extend self
      
      def retrieve_by_customer(url, device_id, password) #:nodoc:
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

      #  ## Retrieve Shipping Addresses By Customer
      #  [Info](https://github.com/PayFabric/APIs/wiki#retrieve-shipping-addresses-by-customer)
      #  
      #  +customer+ - unique name of custumer
      #  
      #  Example
      #    
      #    customer = "abc" 
      #    array = PayFabric::ShippingAdress::Sandbox::retrieve_by_customer(device_id, password, customer)
      #    array # => [{"ID" => "123"}, {"ID" => "124"}, {"ID" => "125"}]
      #    
      #  @return [Array with Adresses](https://github.com/PayFabric/APIs/wiki/API-Objects#address)
      #
      def retrieve_by_customer(device_id, password, customer)
        url = "https://sandbox.payfabric.com/rest/v1/api/addresses/#{customer}"
        Share::retrieve_by_customer(url, device_id, password)
      end

      #  ## Retrieve Shipping Address By Id
      #  [Info](https://github.com/PayFabric/APIs/wiki#retrieve-shipping-address-by-id)
      #  
      #  +id+ - customer id
      #  
      #  Example
      #   
      #    id = "10" 
      #    hash = PayFabric::ShippingAdress::Sandbox::retrieve(device_id, password, id)
      #    hash # => {"ID" => "123"}
      #
      #  @return [Adress Hash](https://github.com/PayFabric/APIs/wiki/API-Objects#address)
      #
      def retrieve(device_id, password, id)
        url = "https://sandbox.payfabric.com/rest/v1/api/address/#{id}"
        Share::retrieve(url, device_id, password)
      end
    end

    module Live
      extend self

      def retrieve_by_customer(device_id, password, customer)
        url = "https://payfabric.com/rest/v1/api/addresses/#{customer}"
        Share::retrieve_by_customer(url, device_id, password)
      end

      def retrieve(device_id, password, id)
        url = "https://payfabric.com/rest/v1/api/address/#{id}"
        Share::retrieve(url, device_id, password)
      end
    end
  end

end