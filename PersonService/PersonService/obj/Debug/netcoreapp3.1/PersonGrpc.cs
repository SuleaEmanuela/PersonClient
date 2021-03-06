// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/person.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PersonService.Protos {
  public static partial class PersonRegistration
  {
    static readonly string __ServiceName = "PersonRegistration";

    static readonly grpc::Marshaller<global::PersonService.Protos.AddPersonRequest> __Marshaller_AddPersonRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PersonService.Protos.AddPersonRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PersonService.Protos.AddPersonResponse> __Marshaller_AddPersonResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PersonService.Protos.AddPersonResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PersonService.Protos.GetAllPersonsResponse> __Marshaller_GetAllPersonsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PersonService.Protos.GetAllPersonsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::PersonService.Protos.AddPersonRequest, global::PersonService.Protos.AddPersonResponse> __Method_AddPerson = new grpc::Method<global::PersonService.Protos.AddPersonRequest, global::PersonService.Protos.AddPersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPerson",
        __Marshaller_AddPersonRequest,
        __Marshaller_AddPersonResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PersonService.Protos.GetAllPersonsResponse> __Method_GetAllPersons = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PersonService.Protos.GetAllPersonsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllPersons",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_GetAllPersonsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PersonService.Protos.PersonReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PersonRegistration</summary>
    [grpc::BindServiceMethod(typeof(PersonRegistration), "BindService")]
    public abstract partial class PersonRegistrationBase
    {
      public virtual global::System.Threading.Tasks.Task<global::PersonService.Protos.AddPersonResponse> AddPerson(global::PersonService.Protos.AddPersonRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllPersons(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::PersonService.Protos.GetAllPersonsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PersonRegistrationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPerson, serviceImpl.AddPerson)
          .AddMethod(__Method_GetAllPersons, serviceImpl.GetAllPersons).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PersonRegistrationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PersonService.Protos.AddPersonRequest, global::PersonService.Protos.AddPersonResponse>(serviceImpl.AddPerson));
      serviceBinder.AddMethod(__Method_GetAllPersons, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::PersonService.Protos.GetAllPersonsResponse>(serviceImpl.GetAllPersons));
    }

  }
}
#endregion
