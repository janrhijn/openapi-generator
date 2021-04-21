//
// Model200Response.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation

/** Model for testing model name starting with number */
public struct Model200Response: Codable, Hashable {

    public var name: Int?
    public var &#x60;class&#x60;: String?

    public init(name: Int? = nil, &#x60;class&#x60;: String? = nil) {
        self.name = name
        self.&#x60;class&#x60; = &#x60;class&#x60;
    }

    public enum CodingKeys: String, CodingKey, CaseIterable {
        case name
        case &#x60;class&#x60; = "class"
    }

}
