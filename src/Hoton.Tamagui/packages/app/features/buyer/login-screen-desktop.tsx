import { useState } from 'react'
import { ColorValue } from 'react-native'
import { YStack, XStack, Input, Button, Text, Image, Stack, Card, Theme } from 'tamagui'

// Define Shopee colors
const shopeeColors = {
  primary: '#ee4d2d',
  secondary: '#fef6f5',
  textGray: '#666666',
  borderColor: '#e8e8e8',
} as Record<string, ColorValue>

export const ShopeeLoginDesktop = () => {
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [showPassword, setShowPassword] = useState(false)

  const handleLogin = () => {
    console.log('Login:', email, password)
  }

  return (
    <Theme name="light">
      <Stack width="100vw" height="100vh" backgroundColor="$background">
        {/* Header */}
        <XStack
          backgroundColor={shopeeColors.primary}
          paddingHorizontal="$6"
          paddingVertical="$4"
          justifyContent="space-between"
          alignItems="center"
        >
          <XStack space="$4" alignItems="center">
            <Image source={{ uri: '/shopee-logo.png' }} width={150} height={50} alt="Shopee Logo" />
            <Text color="white" fontSize="$6" fontWeight="500">
              Login
            </Text>
          </XStack>
          <Button
            backgroundColor="transparent"
            color="white"
            fontSize="$4"
            onPress={() => console.log('Need help?')}
          >
            Need Help?
          </Button>
        </XStack>

        {/* Main Content */}
        <Stack
          flex={1}
          backgroundColor={shopeeColors.secondary}
          paddingVertical="$6"
          alignItems="center"
        >
          <XStack width={1100} maxWidth="90%" flex={1} space="$6">
            {/* Left Banner */}
            <Stack flex={1} justifyContent="center">
              <Image
                source={{ uri: '/login-banner.png' }}
                width="100%"
                height={400}
                resizeMode="contain"
                alt="Login Banner"
              />
            </Stack>

            {/* Login Form */}
            <Card
              width={400}
              backgroundColor="white"
              paddingHorizontal="$6"
              paddingVertical="$5"
              borderRadius="$4"
              elevation={2}
            >
              <YStack space="$4">
                <Text fontSize="$8" fontWeight="600">
                  Login
                </Text>

                <Input
                  size="$4"
                  placeholder="Email/Phone Number"
                  borderColor={shopeeColors.borderColor}
                  borderWidth={1}
                  paddingHorizontal="$3"
                  paddingVertical="$3"
                  value={email}
                  onChangeText={setEmail}
                />

                <Input
                  size="$4"
                  placeholder="Password"
                  borderColor={shopeeColors.borderColor}
                  borderWidth={1}
                  paddingHorizontal="$3"
                  paddingVertical="$3"
                  secureTextEntry={!showPassword}
                  value={password}
                  onChangeText={setPassword}
                />

                <Button
                  backgroundColor={shopeeColors.primary}
                  color="white"
                  size="$4"
                  borderRadius="$2"
                  paddingVertical="$3"
                  onPress={handleLogin}
                  pressStyle={{ opacity: 0.9 }}
                >
                  LOGIN
                </Button>

                <XStack justifyContent="space-between">
                  <Button variant="text" color={shopeeColors.primary}>
                    Forgot Password
                  </Button>
                  <Button variant="text" color={shopeeColors.primary}>
                    Login with SMS
                  </Button>
                </XStack>

                <XStack
                  marginTop="$4"
                  paddingTop="$4"
                  borderTopWidth={1}
                  borderTopColor={shopeeColors.borderColor}
                  alignItems="center"
                  space="$2"
                  justifyContent="center"
                >
                  <Text color={shopeeColors.textGray}>New to Shopee?</Text>
                  <Button variant="text" color={shopeeColors.primary} fontWeight="600">
                    Sign Up
                  </Button>
                </XStack>
              </YStack>
            </Card>
          </XStack>
        </Stack>

        {/* Footer */}
        <XStack
          paddingVertical="$4"
          justifyContent="center"
          backgroundColor="white"
          borderTopWidth={1}
          borderTopColor={shopeeColors.borderColor}
        >
          <Text color={shopeeColors.textGray} fontSize="$3">
            © 2024 Shopee. All Rights Reserved.
          </Text>
        </XStack>
      </Stack>
    </Theme>
  )
}

export default ShopeeLoginDesktop
