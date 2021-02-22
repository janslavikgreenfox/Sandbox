package com.example.BankRestAPIDemo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/hello")
public class HelloWorldController {

    @RequestMapping("")
    @ResponseBody
    public String helloWorld() {
        //String temp = "Hello, this is the REST endpoint.";
        return new String("Hello, this is the REST endpoint");
    };
}
