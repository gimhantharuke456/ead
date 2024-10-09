package com.example.teaapp.service;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\bf\u0018\u00002\u00020\u0001J\u001b\u0010\u0002\u001a\u00020\u00032\b\b\u0001\u0010\u0004\u001a\u00020\u0005H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0006J\u001b\u0010\u0007\u001a\u00020\b2\b\b\u0001\u0010\t\u001a\u00020\nH\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u000bJ%\u0010\f\u001a\u00020\u00032\b\b\u0001\u0010\u0004\u001a\u00020\u00052\b\b\u0001\u0010\r\u001a\u00020\u0003H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u000e\u0082\u0002\u0004\n\u0002\b\u0019\u00a8\u0006\u000f"}, d2 = {"Lcom/example/teaapp/service/UserApi;", "", "getProfile", "Lcom/example/teaapp/model/User;", "userId", "", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "register", "Lcom/example/teaapp/dto/RegisterResponse;", "request", "Lcom/example/teaapp/dto/RegisterRequest;", "(Lcom/example/teaapp/dto/RegisterRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "updateProfile", "user", "(Ljava/lang/String;Lcom/example/teaapp/model/User;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "app_debug"})
public abstract interface UserApi {
    
    @retrofit2.http.POST(value = "api/Users")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object register(@retrofit2.http.Body
    @org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.RegisterRequest request, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.dto.RegisterResponse> $completion);
    
    @retrofit2.http.GET(value = "api/Users/{userId}")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object getProfile(@retrofit2.http.Path(value = "userId")
    @org.jetbrains.annotations.NotNull
    java.lang.String userId, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.model.User> $completion);
    
    @retrofit2.http.PUT(value = "api/Users/{userId}")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object updateProfile(@retrofit2.http.Path(value = "userId")
    @org.jetbrains.annotations.NotNull
    java.lang.String userId, @retrofit2.http.Body
    @org.jetbrains.annotations.NotNull
    com.example.teaapp.model.User user, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.model.User> $completion);
}