'use client'

import { useState } from 'react'
import { YStack, XStack, Input, Button, Text, Stack } from 'tamagui'
import { Eye, EyeOff } from '@tamagui/lucide-icons'

export const LoginScreenMobile = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [showPassword, setShowPassword] = useState(false)

  const handleLogin = () => {
    // Implement login logic here
    console.log('Login:', email, password)

  }

  return (
    <YStack flex={1} backgroundColor="$background">
      {/* Login Form */}
      <YStack flex={1} padding="$4" gap="$4" justifyContent="center">
        <Text fontSize="$8" fontWeight="bold" textAlign="center">
          Logo
        </Text>

        <Text fontSize="$4" color="$gray11" textAlign="center">
          Text
        </Text>

        <YStack gap="$4" marginTop="$6">
          <Input
            size="$4"
            placeholder="Email"
            autoCapitalize="none"
            keyboardType="email-address"
            value={email}
            onChangeText={setEmail}
          />

          <XStack alignItems="center">
            <Input
              flex={1}
              size="$4"
              placeholder="Password"
              secureTextEntry={!showPassword}
              value={password}
              onChangeText={setPassword}
            />
            <Button
              marginLeft="$2"
              icon={showPassword ? EyeOff : Eye}
              circular
              unstyled
              onPress={() => setShowPassword(!showPassword)}
            />
          </XStack>

          <Button size="$4" marginTop="$2" onPress={handleLogin}>
            Sign In
          </Button>

          <XStack marginTop="$2">
            <Button unstyled onPress={() => console.log('Go to signup')}>
              <Text color="$blue10" fontWeight="600">
                註冊
              </Text>
            </Button>
          </XStack>
        </YStack>
      </YStack>
    </YStack>
  )
}
